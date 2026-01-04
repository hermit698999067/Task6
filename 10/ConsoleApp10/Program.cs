using System;

class Storage<T>
{
    private T _value;

    public void Set(T value)
    {
        _value = value;
    }

    public T Get()
    {
        return _value;
    }
}

class Program
{
    static void Main()
    {
        Storage<int> intStorage = new Storage<int>();
        intStorage.Set(42);
        Console.WriteLine(intStorage.Get());

        Storage<string> stringStorage = new Storage<string>();
        stringStorage.Set("Hello");
        Console.WriteLine(stringStorage.Get());
    }
}
