using System;

class Program
{
    static void Main(string[] args)
    {

        int newNumber = -1;
        List<int> numberList = new();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (newNumber != 0)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());

            //Dont add 0 to the list
            if (newNumber != 0)
            {
                numberList.Add(newNumber);

            }
        }

        System.Console.WriteLine($"The sum is: {numberList.Sum()}");
        System.Console.WriteLine($"The average is: {numberList.Average()}");
        System.Console.WriteLine($"The largest number is: {numberList.Max()}");
        System.Console.WriteLine($"The smallest positve number is: {numberList.Where(n => n > 0).Min()}");
        
        //Sort and Print list items
        numberList.Sort();
        foreach (var item in numberList)
        {
            System.Console.WriteLine(item);
        }
    }
}