using System;

class FileLogger : IDisposable
{
    public FileLogger()
    {
        Console.WriteLine("FileLogger создан");
    }

    public void Log(string message)
    {
        Console.WriteLine($"[FileLogger]: {message}");
    }

    public void Dispose()
    {
        Console.WriteLine("FileLogger.Dispose вызван — ресурсы освобождены");
    }
}

class Program
{
    static void Main()
    {
        using (FileLogger logger = new FileLogger())
        {
            logger.Log("Первое сообщение");
            logger.Log("Второе сообщение");
        }

        Console.WriteLine("После блока using");
    }
}
