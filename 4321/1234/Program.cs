using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите количество разрядов для сдвига: ");
        int shift = int.Parse(Console.ReadLine());
        Console.Write("Введите направление сдвига (1 - влево, 2 - вправо): ");
        int direction = int.Parse(Console.ReadLine());

        string numberStr = number.ToString();
        int length = numberStr.Length;

        shift %= length; // Обеспечиваем, что сдвиг не превышает длину числа

        string result = "";

        if (direction == 1)
        {
            result = numberStr.Substring(shift) + numberStr.Substring(0, shift);
        }
        else if (direction == 2)
        {
            result = numberStr.Substring(length - shift) + numberStr.Substring(0, length - shift);
        }
        else
        {
            Console.WriteLine("Некорректное направление сдвига.");
            return;
        }

        Console.WriteLine("Результат сдвига: " + result);
    }
}