using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomeNumberGenrator = new Random();

        int magicNumber = randomeNumberGenrator.Next(1, 101);

        string continuePlaying = "yes";

        while (continuePlaying.ToLower() == "yes")
        {
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            if (guess > magicNumber)
            {
                System.Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                System.Console.WriteLine("Higher");
            }
            else
            {
                System.Console.WriteLine("You guessed it!");
                System.Console.Write("Do you want to play again? ");
                continuePlaying = Console.ReadLine();
                magicNumber = randomeNumberGenrator.Next(1, 101);
            }
        }

    }
}