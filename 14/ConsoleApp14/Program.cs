using System;

class Counter
{
    public int Value { get; private set; }

    public event Action<int> ValueChanged;

    public void Increment()
    {
        Value++;
        ValueChanged?.Invoke(Value);
    }
}

class Program
{
    static void Main()
    {
        Counter counter = new Counter();

        counter.ValueChanged += (val) =>
        {
            Console.WriteLine($"Значение изменилось: {val}");
        };

        counter.Increment(); // Значение изменилось: 1
        counter.Increment(); // Значение изменилось: 2
        counter.Increment(); // Значение изменилось: 3
    }
}
