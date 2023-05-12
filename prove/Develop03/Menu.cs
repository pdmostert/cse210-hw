using System;
public class Menu{


    public static void PrintMenu(){
        System.Console.WriteLine();
        System.Console.WriteLine("Press enter to continue or type 'quit' to finish:");
    }

    public static string GetResponse(){
        string response = Console.ReadLine();
        return response.ToLower();
        
    }


}