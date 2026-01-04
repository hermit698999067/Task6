using System;
using System.Collections.Generic;

class Animal
{
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

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat says: Meow");
    }
}

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();

        animals.Add(new Dog());
        animals.Add(new Cat());
        animals.Add(new Dog());

        foreach (Animal animal in animals)
        {
            animal.Speak();
        }
    }
}
