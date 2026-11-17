using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
 
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
 
    protected override void RunActivity(int seconds)
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        DisplayPrompt();
 
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        ClearKeyBuffer();
 
        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = ReadLineUntil(endTime);

            if (item == null)
            {
                break;
            }
            if (!string.IsNullOrWhiteSpace(item))
            {
                count++;
            }
        }
 
        ClearKeyBuffer();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Time's up!");
        Console.WriteLine($"You listed {count} items!");
    }

    private string ReadLineUntil(DateTime endTime)
    {
        StringBuilder text = new StringBuilder();

        while (DateTime.Now < endTime)
        {
            if (!Console.KeyAvailable)
            {
                Thread.Sleep(50);
                continue;
            }

            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine();
                return text.ToString();
            }
            else if (key.Key == ConsoleKey.Backspace)
            {
                if (text.Length > 0)
                {
                    text.Length--;
                    Console.Write("\b \b");
                }
            }
            else if (!char.IsControl(key.KeyChar))
            {
                text.Append(key.KeyChar);
                Console.Write(key.KeyChar);
            }
        }

        return null;
    }

    private void ClearKeyBuffer()
    {
        while (Console.KeyAvailable)
        {
            Console.ReadKey(true);
        }
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