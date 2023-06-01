using System;
using System.Collections.Generic;
public class ReflectingActivity : PromptActivity
{
    private List<string> _questions;
    public ReflectingActivity()
    {
        ActivityName = "Reflecting";
        ActivityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        Prompts = GeneratePromptList();
        _questions = GenerateQuestions();
    }
    public ReflectingActivity(string activityDescription)
    {
        ActivityName = "Reflecting";
        ActivityDescription = activityDescription;
        Prompts = GeneratePromptList();
        _questions = GenerateQuestions();
    }
    public ReflectingActivity(string activityDescription, List<string> prompts, List<string> questions)
    {
        ActivityName = "Reflecting";
        ActivityDescription = activityDescription;
        Prompts = prompts;
        _questions = questions;
    }
    public ReflectingActivity(List<string> prompts, List<string> questions)
    {
        ActivityName = "Reflecting";
        ActivityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        Prompts = prompts;
        _questions = questions;
    }
    public void ShowReflectingActivity()
    {
        DisplayStartMessage();
        //prompt
        Console.WriteLine("Consider the following prompt: ");
        
        var color = Console.ForegroundColor; //save current forground color
        Console.ForegroundColor = ConsoleColor.Green; //set new color
        Console.WriteLine($"--- {GetRandomPromt()} ---");
        Console.ForegroundColor = color; // return to original color

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        //pause
        DisplayQuestions();

        //loop question and pause for duration

        DisplayEndMessage();
    }
    private void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experiance.");
        Console.Write("You may begin in: ");
        ShowCountdown(3);
        Console.WriteLine();

        DateTime EndTime = DateTime.Now.AddSeconds(ActivityDuration); //Set end time
        while (DateTime.Now < EndTime)
        {
            Console.WriteLine();
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(7);
        }
        Console.WriteLine();
    }
    private string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }
    private List<string> GeneratePromptList()
    {
        List<string> prompts = new();
        prompts.Add("Think of a time when you stood up for someone else. ");
        prompts.Add("Think of a time when you did something really difficult. ");
        prompts.Add("Think of a time when you helped someone in need. ");
        prompts.Add("Think of a time when you did something truly selfless. ");
        return prompts;
    }
    private List<string> GenerateQuestions()
    {
        List<string> questions = new();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Have you ever done anything like this before?");
        questions.Add("How did you get started?");
        questions.Add("How did you feel when it was complete?");
        questions.Add("What made this time different than other times when you were not as successful?");
        questions.Add("What is your favorite thing about this experience?");
        questions.Add("What could you learn from this experience that applies to other situations?");
        questions.Add("What did you learn about yourself through this experience?");
        questions.Add("How can you keep this experience in mind in the future?");
        return questions;
    }


}