using System;

class Program
{
    // Обобщённый метод
    static void PrintType<T>(T value)
    {
        Console.WriteLine($"Значение: {value}, Тип: {typeof(T)}");
    }

    static void Main()
    {
        PrintType(42);           // int
        PrintType(3.14);         // double
        PrintType("Hello");      // string
        PrintType(true);         // bool
    }
}
