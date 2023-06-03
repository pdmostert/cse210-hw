using System;
public class Rectangle : Shape
{
    private double _lenth;
    private double _width;

    public Rectangle(double width, double lenth, string color) : base(color)
    {
        _width = width;
        _lenth = lenth;
    }

    public override double GetArea()
    {
        return _lenth * _width;
    }



}