using System;
using System.Collections.Generic;
 
public class ReflectingActivity : Activity
{
    private PromptPool _prompts = new PromptPool(new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    });
 
    private PromptPool _reflectionPrompts = new PromptPool(new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    });
 
    public ReflectingActivity()
        : base("Reflecting Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }
 
    protected override void RunActivity()
    {
        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
 
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.Clear();
 
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
 
        while (DateTime.Now < endTime)
        {
            DisplayReflectionPrompt();
        }
    }
 
    private string GetPrompt()
    {
        return _prompts.GetNext();
    }
 
    private string GetReflectionPrompt()
    {
        return _reflectionPrompts.GetNext();
    }
 
    private void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine($"--- {GetPrompt()} ---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
 
    private void DisplayReflectionPrompt()
    {
        Console.Write($"> {GetReflectionPrompt()} ");
        ShowSpinner(8);
        Console.WriteLine();
    }
}