using System;

interface ILogger
{
    void Log(string message)
    {
        Console.WriteLine($"[LOG]: {message}");
    }
}

class FileLogger : ILogger
{

}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[CONSOLE]: {message}");
    }
}

class Program
{
    static void Main()
    {
        ILogger logger1 = new FileLogger();
        ILogger logger2 = new ConsoleLogger();

        logger1.Log("Сообщение 1");
        logger2.Log("Сообщение 2");
    }
}
