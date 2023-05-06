using System;

class Program
{
    static void Main(string[] args)
    {

        Journal myJournal = new Journal();
        PromptGenerator pg = new();
        int choice = 0;

        while (choice != 5)
        {
            Menu.PrintMenu(myJournal.Status());
            choice = Menu.GetSelectedMenuOption(1, 6);

            switch (choice)
            {
                case 1: //Write
                    Menu.MenuChoice1(myJournal, pg);
                    break;
                case 2: //Display
                    Menu.MenuChoice2(myJournal);
                    break;
                case 3: //Load
                    myJournal = Menu.MenuChoice3(myJournal);
                    break;
                case 4: // Save
                    Menu.MenuChoice4(myJournal);
                    break;
                case 5:
                    Menu.MenuChoice5(myJournal);
                    break;
                case 6:
                    pg = Menu.MenuChoice6(pg);
                    break;
                default:
                    break;
            }

        }
    }
}

// CSV File, read and write
//Journal Entry : Date, Prompt, Entry
//Journal with list of entries
//Menu :  write, display, load, save , quit
//Prompts
