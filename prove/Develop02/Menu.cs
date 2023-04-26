public class Menu
{

    public static void PrintMenu(string status = "")
    {

        System.Console.WriteLine($"Welcome to the Journal Program! {status} ");
        System.Console.WriteLine($"1. Write");
        System.Console.WriteLine($"2. Display");
        System.Console.WriteLine($"3. Load");
        System.Console.WriteLine($"4. Save");
        System.Console.WriteLine($"5. Quit");
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

            while (choice < min || choice > max )
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

}