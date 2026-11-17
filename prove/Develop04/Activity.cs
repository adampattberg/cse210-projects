using System;
using System.Threading;

// abstract makes child class determine logic
public abstract class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _seconds;
 
    protected Activity(string name, string description)
    {
        _activityName = name;
        _activityDescription = description;
    }
 
        public void Run()
    {
        DisplayStartMessage();
        RunActivity(_seconds);
        DisplayEndMessage();
    }

// protected means child classes can read the duration but can't change it.
// abstract makes child class determine logic

    protected abstract void RunActivity(int seconds);
 
    private void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();


        while (true)
        {
            Console.Write("How long, in seconds, would you like for your session? ");
            if (int.TryParse(Console.ReadLine(), out int seconds) && seconds > 0)
            {
                _seconds = seconds;
                break;
            }
            Console.WriteLine("Please enter a whole number greater than 0.");
        }

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
        Console.WriteLine($"You have completed another {_seconds} seconds of the {_activityName}.");
        ShowSpinner(5);
    }
 
    // Pause and spin
    public static void ShowSpinner(int seconds)
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