using System.Runtime.ConstrainedExecution;
using System;

class Program
{

///  To exceed requirements I have ensured that the random hiding of words is never duplicated.
/// I also created a DataAccess class to load multiple scriptures from a text file.
/// A menu to select the scripture to memorize.

    static void Main(string[] args)
    {
        //Clear before we start
        System.Console.Clear();

        List<Scripture> scriptures = new();
        scriptures = DataAccess.LoadFile(); //Load scriptures from file

        //Print scripture select menu and load selected scripture
        int count = Menu.PrintScriptureChoiceMenu(scriptures);
        int selectedScriptureIndex =  Menu.GetSelectedMenuOption(1,count) -1;
        Scripture scripture = scriptures[selectedScriptureIndex];

        //start memorize menu and loop exit when complete or quit
        string response = "";

        while (response != "quit")
        {
            System.Console.Clear();
            Console.WriteLine(scripture.GetRenderedText());
            Menu.PrintMenu();
            if (scripture.IsCompletlyHiden())
            {
                break;
            }
            response = Menu.GetResponse();
            scripture.HideWords();
        }
    }
}