using System;
public static class Menu
{

    public static void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breating activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");

    }

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