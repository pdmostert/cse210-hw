using System;
public sealed class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        base.ActivityName = "Breathing";
        base.ActivityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }


/// <summary>
/// The function displays a breathing exercise with a countdown timer for a specified duration.
/// </summary>
    public void StartBreathing()
    {
        base.DisplayStartMessage();
        DateTime EndTime = DateTime.Now.AddSeconds(ActivityDuration); //Set end time
        while (DateTime.Now < EndTime)
        {
            Console.WriteLine();
            Console.Write("Breathe In...");
            base.ShowCountdown(6);
            Console.WriteLine();
            System.Console.Write("Now breathe out...");
            base.ShowCountdown(6);
            Console.WriteLine();
        }
        base.DisplayEndMessage();
    }
}