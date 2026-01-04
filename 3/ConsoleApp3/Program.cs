using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Rectangle : Shape
{
    public double Width;
    public double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(5, 3);
        Console.WriteLine("Площадь прямоугольника: " + rect.GetArea());
    }
}
