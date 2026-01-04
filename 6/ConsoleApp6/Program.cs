using System;

sealed class FinalReport
{
    public void Print()
    {
        Console.WriteLine("Final report printed");
    }
}

/*
Попытка наследования — приведёт к ошибке компиляции
class ExtendedReport : FinalReport
*/

class Program
{
    static void Main()
    {
        FinalReport report = new FinalReport();
        report.Print();
    }
}
