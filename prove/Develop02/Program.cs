using System;

class Program
{
    static void Main(string[] args)
    {

        Journal myJournal = new Journal();
        PromptGenerator pg = new();
        string filename = "";
        int choice = 0;


        while (choice != 5)
        {
            Menu.PrintMenu(myJournal.Status());
            choice = Menu.GetSelectedMenuOption(1, 5);

            switch (choice)
            {
                case 1: //Write
                    string prompt = pg.GetRandomPrompt();
                    System.Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    Entry myEntry = new Entry(prompt, response);
                    myJournal.AddJournalEntry(myEntry);
                    break;
                case 2: //Display
                    foreach (var item in myJournal.Entries)
                    {
                        System.Console.WriteLine(item.Display());
                        System.Console.WriteLine();
                    }
                    break;
                case 3: //Load
                    if (myJournal.IsSaved == false && myJournal.Entries.Count > 0)
                    {
                        System.Console.WriteLine("Your Journal has been modified since it's last save,  would you like to save it now? Y/N");
                        string mustSave = Menu.GetYN();
                        if (mustSave.ToLower()[0] == 'y')
                        {
                            System.Console.Write("What is the filename to save? ");
                            filename = Console.ReadLine();
                            DataAccess.WriteJournalFile(filename, myJournal);
                        }
                        else
                        {
                            System.Console.Write("What is the filename to load? ");
                            filename = Console.ReadLine();
                            myJournal = new(DataAccess.ReadJournalFile(filename));
                            myJournal.JournalSaved();
                        }
                    }
                    else
                    {
                        System.Console.Write("What is the filename to load? ");
                        filename = Console.ReadLine();
                        myJournal = new(DataAccess.ReadJournalFile(filename));
                        myJournal.JournalSaved();
                    }
                    break;
                case 4: // Save
                    System.Console.Write("What is the filename to save? ");
                    filename = Console.ReadLine();
                    DataAccess.WriteJournalFile(filename, myJournal);
                    break;
                case 5:
                    if (myJournal.IsSaved == false)
                    {
                        System.Console.WriteLine("Your Journal has been modified since it's last save,  would you like to save it now? Y/N");
                        string mustSave = Menu.GetYN();
                        if (mustSave.ToLower()[0] == 'y')
                        {
                            System.Console.Write("What is the filename to save? ");
                            filename = Console.ReadLine();
                            DataAccess.WriteJournalFile(filename, myJournal);
                        }
                    }
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
