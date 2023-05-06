public class Menu
{

    public static void PrintMenu(string status = "")
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"Welcome to the Journal Program! {status} ");
        System.Console.WriteLine($"1. Write");
        System.Console.WriteLine($"2. Display");
        System.Console.WriteLine($"3. Load");
        System.Console.WriteLine($"4. Save");
        System.Console.WriteLine($"5. Quit");
        System.Console.WriteLine($"6. Add new daily prompt");
        System.Console.Write($"What would you like to do? ");
    }

    /// <summary>
    /// This function gets a user's selected menu option within a specified range of values.
    /// </summary>
    /// <param name="min">The minimum value that the user can enter as a menu option.</param>
    /// <param name="max">The maximum value that the user is allowed to enter.</param>
    /// <returns>
    /// The method is returning an integer value, which is the user's selected menu option within the
    /// specified range of minimum and maximum values.
    /// </returns>
    public static int GetSelectedMenuOption(int min, int max)
    {
        //Used tryparse incase someone enters a value other then a int
        int choice = 0;
        string response = Console.ReadLine();
        bool success = int.TryParse(response, out choice);

        while (choice < min || choice > max)
        {
            System.Console.WriteLine($"Please enter a value between {min} and {max}");
            response = Console.ReadLine();
            success = int.TryParse(response, out choice);
        }
        return choice;
    }

    /// <summary>
    /// The function prompts the user to enter "Y" or "N" and returns the lowercase version of the input.
    /// </summary>
    /// <returns>
    /// The method is returning a string value, which is the user's choice of either "y" or "n".
    /// </returns>
    public static string GetYN()
    {
        string choice = Console.ReadLine().ToLower();
        while (choice != "y" && choice != "n")
        {
            System.Console.WriteLine("Please enter Y or N: ");
            choice = Console.ReadLine().ToLower();
        }
        return choice;
    }

/// <summary>
/// The function prompts the user with a random prompt, takes their response, creates a new journal
/// entry with the prompt and response, and adds it to the journal.
/// </summary>
/// <param name="Journal">A class that represents a journal or diary, which contains a collection of
/// entries.</param>
/// <param name="PromptGenerator">PromptGenerator is a class that generates random prompts for journal
/// entries. It is used in the MenuChoice1 method to get a random prompt for the user to respond
/// to.</param>
    public static void MenuChoice1(Journal myJournal, PromptGenerator pg)
    {
        string prompt = pg.GetRandomPrompt();
        System.Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
        Entry myEntry = new Entry(prompt, response);
        myJournal.AddJournalEntry(myEntry);

    }
/// <summary>
/// The function displays all entries in a journal.
/// </summary>
/// <param name="Journal">The parameter "myJournal" is an instance of the Journal class, which is likely
/// a custom class created by the programmer to represent a journal or diary. The method MenuChoice2
/// takes this instance as a parameter and uses it to display all the entries in the journal.</param>
    public static void MenuChoice2(Journal myJournal)
    {
        System.Console.WriteLine();
        foreach (var item in myJournal.Entries)
        {
            System.Console.WriteLine(item.Display());
            System.Console.WriteLine();
        }

    }
/// <summary>
/// This function loads or saves a journal file based on user input and returns the updated journal.
/// </summary>
/// <param name="Journal">A class representing a journal, containing a list of entries and a boolean
/// indicating whether it has been saved or not.</param>
/// <returns>
/// The method is returning an instance of the Journal class.
/// </returns>
    public static Journal MenuChoice3(Journal myJournal)
    {
        string filename;
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
        return myJournal;
    }

/// <summary>
/// This function prompts the user for a filename and saves a journal object to a file using the
/// DataAccess class.
/// </summary>
/// <param name="Journal">The Journal parameter is an object of the Journal class, which contains
/// information about a person's daily activities, thoughts, and experiences. It may include entries
/// such as the date, time, location, and description of events.</param>
    public static void MenuChoice4(Journal myJournal)
    {
        string filename;
        System.Console.Write("What is the filename to save? ");
        filename = Console.ReadLine();
        DataAccess.WriteJournalFile(filename, myJournal);
    }

/// <summary>
/// This function prompts the user to save their journal if it has been modified since the last save.
/// </summary>
/// <param name="Journal">The Journal parameter is an object of the Journal class, which represents a
/// journal that the user has created and is currently working on. It contains various properties and
/// methods to manage the journal entries and perform operations on them.</param>
    public static void MenuChoice5(Journal myJournal)
    {
        string filename;
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
    }

/// <summary>
/// The function prompts the user to enter a new daily prompt and adds it to the prompt generator.
/// </summary>
/// <param name="PromptGenerator">PromptGenerator is a class that likely contains methods and properties
/// related to generating prompts. It is being used as a parameter for the MenuChoice6 method, which
/// suggests that MenuChoice6 is a method within the PromptGenerator class.</param>
/// <returns>
/// The method is returning an instance of the PromptGenerator class.
/// </returns>
    public static PromptGenerator MenuChoice6(PromptGenerator pg)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Enter new daily prompt. ");
        string prompt = Console.ReadLine();
        if (prompt.Length > 0)
        {
            pg.AddNewPrompt(prompt);
        }
        return pg;
    }



}