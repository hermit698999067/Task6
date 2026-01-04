using System;
using System.Collections.Generic;
using System.Linq;

interface IEmployee
{
    decimal GetSalary();
}

abstract class EmployeeBase : IEmployee
{
    public string Name { get; set; }

    public EmployeeBase(string name)
    {
        Name = name;
    }

    public abstract decimal GetSalary();
}

class Manager : EmployeeBase
{
    public decimal BaseSalary { get; set; }
    public decimal Bonus { get; set; }

    public Manager(string name, decimal baseSalary, decimal bonus) : base(name)
    {
        BaseSalary = baseSalary;
        Bonus = bonus;
    }

    public override decimal GetSalary()
    {
        return BaseSalary + Bonus;
    }
}

class Developer : EmployeeBase
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Developer(string name, decimal hourlyRate, int hoursWorked) : base(name)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal GetSalary()
    {
        return HourlyRate * HoursWorked;
    }
}

class Program
{
    static void Main()
    {
        List<IEmployee> employees = new List<IEmployee>
        {
            new Manager("artem", 5000, 1000),
            new Developer("amir", 50, 160),
            new Manager("adil", 6000, 1500),
            new Developer("alisher", 60, 150)
        };

        // Полиморфизм: вызываем GetSalary() без проверки типа
        decimal totalSalary = employees.Sum(e => e.GetSalary());
        decimal averageSalary = employees.Average(e => e.GetSalary());
        IEmployee highestPaid = employees.OrderByDescending(e => e.GetSalary()).First();

        Console.WriteLine($"Общая сумма зарплат: {totalSalary}");
        Console.WriteLine($"Средняя зарплата: {averageSalary}");
        Console.WriteLine($"Сотрудник с максимальной зарплатой: {((EmployeeBase)highestPaid).Name} - {highestPaid.GetSalary()}");
    }
}
