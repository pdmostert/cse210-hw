using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new();

        Running running = new(DateOnly.FromDateTime(DateTime.Now), 30, 6);
        Cycling cycling = new(DateOnly.Parse("2023/11/03"), 30, 16);
        Swimming swimming = new(DateOnly.Parse("2023/11/03"), 30, 30);


        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);


        foreach (var item in activities)
        {
            System.Console.WriteLine(item.GetSummary());
        }


    }
}