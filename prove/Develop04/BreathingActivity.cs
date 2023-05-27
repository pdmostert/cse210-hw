using System;
public class BreathingActivity : Activity
{


    public BreathingActivity()
    {
        base.ActivityName = "Breathing";
        base.ActivityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }



    public void ShowBreathing()
    {
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
    }
}