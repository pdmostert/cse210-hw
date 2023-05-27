using System;
public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;


    public string ActivityName
    {
        get { return _activityName; }
        set { _activityName = value; }

    }
    public string ActivityDescription
    {
        get { return _activityDescription; }
        set { _activityDescription = value; }
    }
    public int ActivityDuration
    {
        get { return _activityDuration; }
        private set {; }
    }

    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine(_activityDescription);
        Console.WriteLine();
        Console.Write("How long, in seconds would you like for your session? ");
        _activityDuration = int.Parse(Console.ReadLine());
        Console.Clear();
        System.Console.WriteLine("Get ready...");
        ShowSpinner();
        Console.WriteLine();
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        System.Console.WriteLine();
        System.Console.WriteLine($"You have completed another {_activityDuration} seconds of {_activityName} Activity.");
        ShowSpinner();
    }

    private void ShowSpinner()
    {

        List<string> symbols = new();
        symbols.Add("|");
        symbols.Add("/");
        symbols.Add("-");
        symbols.Add("\\");
        symbols.Add("|");
        symbols.Add("/");
        symbols.Add("-");
        symbols.Add("\\");

        int index = 0;
        for (int i = 0; i < 50; i++)
        {
            Console.Write(symbols[index]);
            Thread.Sleep(100);
            Console.Write("\b \b");
            index++;
            if (index >= 8)
            {
                index = 0;
            }
        }
    }

    protected void ShowCountdown(int number)
    {
        for (int i = number; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SaveActivityToFile()
    {

    }


}