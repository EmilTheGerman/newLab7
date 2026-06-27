using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Task1();

        Console.WriteLine("\nНатиснiть будь-яку клавiшу...");
        Console.ReadKey();
        Console.Clear();

        Task2();

        Console.WriteLine("\nНатиснiть будь-яку клавiшу для завершення...");
        Console.ReadKey();


    }

    static void Task1()
    {
        Console.WriteLine("========== Завдання 1 ==========\n");

        Console.WriteLine("Неправильний варiант:");

        List<Action> actions = new List<Action>();

        for (int i = 1; i <= 5; i++)
        {
            actions.Add(() => Console.WriteLine(i));
        }

        foreach (Action action in actions)
            action();

        Console.WriteLine("\nПравильний варiант:");

        actions.Clear();

        for (int i = 1; i <= 5; i++)
        {
            int copy = i;

            actions.Add(() => Console.WriteLine(copy));
        }

        foreach (Action action in actions)
            action();
    }
    static void Task2()
    {
        Console.WriteLine("========== Завдання 2 ==========\n");

        BankTerminal terminal = new BankTerminal();

        terminal.OnMoneyWithdraw += amount =>
        {
            Console.WriteLine($"Повiдомлення: з рахунку знято {amount} грн.");
        };

        terminal.Withdraw(500);

        Console.WriteLine();
        Console.WriteLine("Спроба виконати:");
        Console.WriteLine("terminal.OnMoneyWithdraw = null;");
        Console.WriteLine("terminal.OnMoneyWithdraw?.Invoke(1000);");

        Console.WriteLine();
        Console.WriteLine("Обидвi операцiї викликають помилки компiляцiї,");
        Console.WriteLine("оскiльки використано ключове слово event.");
    }
}
class BankTerminal
{
    public event Action<int>? OnMoneyWithdraw;

    public void Withdraw(int amount)
    {
        Console.WriteLine($"Знято {amount} грн.");
        OnMoneyWithdraw?.Invoke(amount);
    }
}