using System;

interface IPrintable
{
    void Print();
}

class Report : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Printing report...");
    }
}

class Program
{
    static void Main()
    {
        IPrintable printable = new Report();
        printable.Print();
    }
}
