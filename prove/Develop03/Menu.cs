using System.Threading;
using System;
public class Menu
{


    public static void PrintMenu()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    }

    public static string GetResponse()
    {
        string response = Console.ReadLine();
        return response.ToLower();
    }


/// <summary>
/// This function prints a menu of scripture choices and returns the user's selection.
/// </summary>
/// <param name="scriptures">A list of Scripture objects that contains the references to the scriptures
/// that the user can choose from.</param>
/// <returns>
/// The method is returning an integer value which represents the number of the scripture that the user
/// has selected to memorize.
/// </returns>
    public static int PrintScriptureChoiceMenu(List<Scripture> scriptures)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Select the number of the scripture you would like to memorize today: ");
        
        int count = 1;
        foreach (var item in scriptures)
        {
            System.Console.WriteLine($"{count} : {item.GetScriptureReference()}");
            count ++;
        }
        System.Console.Write("> ");
        return count -1;
    }

/// <summary>
/// This function gets a user's selected menu option within a specified range and returns it as an
/// integer.
/// </summary>
/// <param name="min">The minimum value that the user can enter as a menu option.</param>
/// <param name="max">The maximum value that the user can enter as a menu option.</param>
/// <returns>
/// The method is returning an integer value which is the user's selected menu option within the range
/// of minimum and maximum values provided as parameters.
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


}