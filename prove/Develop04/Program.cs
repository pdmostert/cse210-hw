using System;

class Program
{
    static void Main(string[] args)
    {

        int choice = 0;

        while (choice != 4)
        {
            Menu.ShowMenu();
            choice = Menu.GetSelectedMenuOption(1, 4);

            switch (choice)
            {
                case 1:
                    BreathingActivity breath = new();
                    breath.ShowBreathing();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new();
                    reflectingActivity.ShowReflectingActivity();
                    break;
                case 3:
                    ListingActivity listing = new();
                    listing.ShowListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Good Bye");
                    break;
                default:
                    break;
            }
        }













    }
}