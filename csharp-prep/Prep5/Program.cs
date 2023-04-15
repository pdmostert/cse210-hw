using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int number = PromptUserNumber();
        
        DisplayResult(userName,SquareNumber(number));
    }

    static void DisplayWelcome()
    {
        System.Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        System.Console.Write("Please enter your name: ");
        string response = Console.ReadLine();
        return response;
    }
    static int PromptUserNumber()
    {
                System.Console.Write("Please enter your favorite number: ");
        string response = Console.ReadLine();
        return int.Parse(response);
    }
    static int SquareNumber(int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }
    static void DisplayResult(string userName, int number)
    {
        System.Console.WriteLine($"{userName}, the square of your number is {number}");
    }



}