using System;
using System.Threading;

// abstract makes child class determine logic
public abstract class Activity
{
    private string _activityName;
    private string _activityDescription;
 
    protected Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }
 
        public void Run()
    {
        DisplayStartMessage();
        RunActivity();
        DisplayEndMessage();
    }

// protected means child classes can read the duration but can't change it.
// abstract makes child class determine logic

    protected abstract void RunActivity();
 
    private void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.WriteLine("Press enter when you are ready to begin.");
        Console.ReadLine();

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
        Console.WriteLine($"You have completed the {_activityName}.");
        ShowSpinner(5);
    }
 
    // Pause and spin
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
 
    // Pause and count down
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