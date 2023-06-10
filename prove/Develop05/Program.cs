using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal sGoal = new SimpleGoal("Test", "Test", 50);


        List<Goal> goals = new List<Goal>();
        goals.Add(sGoal);
        
        foreach (var item in goals)
        {
            Console.WriteLine(item.ShowGoalProgress());
        }

    }
}