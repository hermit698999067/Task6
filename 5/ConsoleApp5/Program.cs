using System;

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

    public void Run()
    {
        Console.WriteLine("Dog is running");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Dog();

        Dog dog1 = (Dog)animal;
        dog1.Run();

        Dog dog2 = animal as Dog;
        if (dog2 != null)
        {
            dog2.Run();
        }
        else
        {
            Console.WriteLine("Приведение не удалось");
        }
    }
}
