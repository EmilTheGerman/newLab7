using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Task1();

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
}