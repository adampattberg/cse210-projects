using System;
using System.Collections.Generic;
 
public class ListingActivity : Activity
{
    private PromptPool _prompts = new PromptPool(new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    });
 
    public ListingActivity()
        : base("Listing Activity",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
 
    protected override void RunActivity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();
 
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();
 
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
 
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }
 
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items!");
    }
 
    private string GetPrompt()
    {
        return _prompts.GetNext();
    }
 
    private void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine($"--- {GetPrompt()} ---");
        Console.WriteLine();
    }
}