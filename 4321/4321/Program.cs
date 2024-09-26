using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine()
            );

        int reversed = 0;
        int original = number;

        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        if (original == reversed)
        {
            Console.WriteLine("Число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом.");
        }
    }
}