using System;

delegate int Operation(int a, int b);

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Main()
    {
        Operation op = Add;
        Console.WriteLine("Add: " + op(3, 5));

        op = Multiply;
        Console.WriteLine("Multiply: " + op(3, 5));

        op = (x, y) => x - y;
        Console.WriteLine("Subtract (lambda): " + op(10, 4));
    }
}
