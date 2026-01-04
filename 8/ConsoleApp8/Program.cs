using System;

interface IPayment
{
    void Pay(decimal amount);
}

class CashPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата наличными: {amount} тг");
    }
}

class CardPayment : IPayment
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата картой: {amount} тг");
    }
}

class Program
{
    static void Main()
    {
        // Выбор реализации
        IPayment payment;

        bool useCard = true;

        if (useCard)
            payment = new CardPayment();
        else
            payment = new CashPayment();

        payment.Pay(1500m);
    }
}
