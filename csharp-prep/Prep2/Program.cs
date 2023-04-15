using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("");
        Console.Write("Please enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        //get last digit
        int last_digit = grade % 10;


        //chek if it is a + or -
        if (last_digit >= 7)
        {
            sign = "+";
        }
        else if (last_digit < 3)
        {
            sign = "-";
        }

        if (letter.ToLower() == "a")
        {
            if (sign == "+")
            {
                sign = "";
            }
        }
        else if (letter.ToLower() == "f")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");

        if (grade >=70){
            System.Console.WriteLine("You passed!");
        }
        else
        {
            System.Console.WriteLine("You did not pass the grade!");
        }

    }
}