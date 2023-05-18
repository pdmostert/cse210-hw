using System.Runtime.ConstrainedExecution;
using System;

class Program
{
    static void Main(string[] args)
    {
        //Clear before we start
        System.Console.Clear();

        // Load dummy content
        Reference reference = new("Proverbs", 3, 5, 6);
        string sentance = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new(reference, sentance);


        //start menu and loop exit when complete or quit
        string response = "";
        // System.Console.WriteLine(scripture.GetRenderedText());
        // Menu.PrintMenu();
        // response = Menu.GetResponse();

        while (response != "quit")
        {
            if (scripture.IsCompletlyHiden())
            {
                break;
            }
            System.Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Menu.PrintMenu();
            response = Menu.GetResponse();
            scripture.HideWords();
        }

    }
}