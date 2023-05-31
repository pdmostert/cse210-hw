using System;
using System.Collections.Generic;
public class ListingActivity : PromptActivity
{
    private List<string> _responses;
    public ListingActivity()
    {
        ActivityName = "Listing";
        ActivityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        Prompts = GeneratePromptList();
        _responses = new();
    }

    public void ShowListingActivity()
    {
        base.DisplayStartMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");

        var color = Console.ForegroundColor; //save current forground color
        Console.ForegroundColor = ConsoleColor.Green; //set new color
        Console.WriteLine($"--- {GetRandomPromt()} ---");
        Console.ForegroundColor = color; // return to original color

        Console.Write("You may begin in: ");
        ShowCountdown(9);
        Console.WriteLine();

        DateTime EndTime = DateTime.Now.AddSeconds(ActivityDuration); //Set end time
        while (DateTime.Now < EndTime)
        {
            Console.Write("> ");
            _responses.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {_responses.Count} items!");

        base.DisplayEndMessage();
    }

    private List<string> GeneratePromptList()
    {
        List<string> prompts = new();
        prompts.Add("Who are people that you appreciate? ");
        prompts.Add("What are personal strengths of yours? ");
        prompts.Add("Who are people that you have helped this week? ");
        prompts.Add("When have you felt the Holy Ghost this month? ");
        prompts.Add("Who are some of your personal heroes? ");
        return prompts;
    }


}