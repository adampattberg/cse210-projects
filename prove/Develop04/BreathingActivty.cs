using System;
 
public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
 
 // overrides abstract RunActivity for AlternatingMessage
    protected override void RunActivity()
    {
        AlternatingMessage();
    }
 
    private void AlternatingMessage()
    {
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
 
        while (DateTime.Now < endTime)
        {
            Breathe("Breathe in...", 4, endTime);
            Breathe("Breathe out...", 6, endTime);
        }
    }
 
    // Shows one message with a countdown, without running past the end time.
    private void Breathe(string message, int seconds, DateTime endTime)
    {
        int remaining = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);
        if (remaining <= 0)
        {
            return;
        }
 
        Console.Write($"{message} ");
        ShowCountdown(Math.Min(seconds, remaining));
        Console.WriteLine();
    }
}