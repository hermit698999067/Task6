using System;

class Animal
{
    public string Name;

    public virtual void Speak()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog says: Woof");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog();
        dog.Name = "Бобик";

        Console.WriteLine("Name: " + dog.Name);
        dog.Speak();
    }
}
