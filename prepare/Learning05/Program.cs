using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Square square = new(10, "blue");
        Rectangle rectangle = new(10, 20, "Green");
        Circle circle = new(15, "Red");

        List<Shape> shapes = new();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (var item in shapes)
        {
            Console.WriteLine($"The {item.GetColor()} {item.GetType()} shape has an area of {item.GetArea()}.");
        }

    }
}