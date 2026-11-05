using System;
using System.Threading;

public abstract class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
 
    protected Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }
 
    // Child classes can read the duration but can't change it.
    protected int Duration
    {
        get { return _activityDuration; }
    }
 
    // Template method: every activity runs in the same order.
    // Program only ever calls this one method.
    public void Run()
    {
        DisplayStartMessage();
        RunActivity();      // the only part that differs per activity
        DisplayEndMessage();
    }
 
    protected abstract void RunActivity();
 
    private void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
 
        _activityDuration = AskForDuration();
 
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
    }
 
    private void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName}.");
        ShowSpinner(5);
    }
 
    private static int AskForDuration()
    {
        while (true)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            if (int.TryParse(Console.ReadLine(), out int seconds) && seconds > 0)
            {
                return seconds;
            }
            Console.WriteLine("Please enter a whole number greater than 0.");
        }
    }
 
    // Pause and spin (the UML's "Pause&Spin")
    protected static void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;
 
        while (DateTime.Now < endTime)
        {
            Console.Write(frames[i % frames.Length]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
        }
    }
 
    // Pause and count down (the UML's "Pause&Count")
    protected static void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            string text = i.ToString();
            Console.Write(text);
            Thread.Sleep(1000);
            // Erase every digit, so "10" doesn't leave a stray "1" behind
            Console.Write(new string('\b', text.Length) + new string(' ', text.Length) + new string('\b', text.Length));
        }
    }
}