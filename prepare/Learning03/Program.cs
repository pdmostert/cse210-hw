using System;

class Program
{
    static void Main(string[] args)
    {


        List<Fraction> fractions = new();
        Fraction baseFraction = new();
        Fraction wholeFraction = new(6);
        Fraction fullFraction = new(6, 7);
        Fraction f3 = new(3,4);
        fractions.Add(baseFraction);
        fractions.Add(wholeFraction);
        fractions.Add(fullFraction);
        fractions.Add(f3);

        foreach (var item in fractions)
        {
            System.Console.WriteLine(item.GetFractionString());
            System.Console.WriteLine(item.GetTop());
            System.Console.WriteLine(item.GetDecimalValue());
            System.Console.WriteLine();
        }


    }
}