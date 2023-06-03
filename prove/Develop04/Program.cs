using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Menu.ShowMenu();
            choice = Menu.GetSelectedMenuOption(1, 5);

            switch (choice)
            {
                case 1:
                    BreathingActivity breath = new();
                    breath.StartBreathing();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.StartReflectingActivity();
                    break;
                case 3:
                    ListingActivity listing = new();
                    listing.StartListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Good Bye");
                    break;
                case 5:
                    List<ActivityLog> log = new();
                    log = DataAccess.LoadFile();
                    Console.Clear();
                    Console.WriteLine("Activity Log:");
                    foreach (var item in log)
                    {
                        Console.WriteLine(item.DisplayActivityLog());
                    }
                    Console.WriteLine();
                    Console.Write("End of Log, press Enter to continue: ");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }













    }
}