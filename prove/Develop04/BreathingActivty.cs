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
    protected override void RunActivity()
    {
        for (int i = 0; i < BreathCycles; i++)
        {
            Breathe("Breathe in...", 4);
            Breathe("Breathe out...", 6);
            Console.WriteLine("");
        }
    }
 
    // Shows one message with a countdown, without running past the end time.
    private void Breathe(string message, int seconds)
    {
        Console.Write($"{message} ");
        ShowCountdown(seconds);
        Console.WriteLine("");
    }
}