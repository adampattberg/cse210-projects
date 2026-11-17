using System;
 
public class BreathingActivity : Activity
{
    private const int BreathCycles = 3;
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
 
 // overrides abstract RunActivity for AlternatingMessage
    protected override void RunActivity(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Breathe("Breathe in...", 4, endTime);
            Breathe("Breathe out...", 6, endTime);
            Console.WriteLine("");
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
        Console.WriteLine("");
    }
}