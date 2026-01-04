using System;

class Animal
{
    public string Name;

    public void Speak()
    {
        Console.WriteLine("*гавкоет*");
    }
}

class Dog : Animal
{
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Name = "Бобик";

        Console.WriteLine("Имя собаки: " + dog.Name);
        dog.Speak();
    }
}
