public static class Menu{


    public static void ShowMenu(List<string> menuOptions,string menuHeading = "Menu Options: ",string menuFooter = "Please select a menu option: "  )
    {
       //Console.Clear();
        Console.WriteLine(menuHeading);
        foreach (var item in menuOptions)
        {
            Console.WriteLine($"  {menuOptions.IndexOf(item)+1}. {item}");
        }
        Console.Write(menuFooter);

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

    public static List<string> GetBaseMenu(){
        List<string> menuOptions = new List<string>();
        menuOptions.Add("Add Goal");
        menuOptions.Add("List Goals");
        menuOptions.Add("Save Goals");
        menuOptions.Add("Load Goals");
        menuOptions.Add("Record Event");
        menuOptions.Add("Exit");
        return menuOptions;
    }

    public static List<string> GetGoalMenu(){
        List<string> menuOptions = new List<string>();
        menuOptions.Add("Simple Goal");
        menuOptions.Add("Eternal Goal");
        menuOptions.Add("Check List Goal");
        return menuOptions;
    }
}