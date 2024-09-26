using System;

class Program
{
    static void Main()
    {
        int maxLength = 0; 
        int currentLength = 1; 
        int startIndex = -1; 
        int maxStartIndex = -1; 
        Console.WriteLine("Введите 15 целых чисел:");

        int previousNumber = int.Parse(Console.ReadLine());
        startIndex = 1; 

        for (int i = 2; i <= 15; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());

            if (currentNumber >= previousNumber) 
            {
                currentLength++;
            }
            else 
            {
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    maxStartIndex = startIndex;
                }
                currentLength = 1;
                startIndex = i; 
            }

            previousNumber = currentNumber; 
        }

       
        if (currentLength > maxLength)
        {
            maxLength = currentLength;
            maxStartIndex = startIndex;
        }

        Console.WriteLine($"Максимальная длина цепочки: {maxLength}");
        Console.WriteLine($"Порядковый номер числа, с которого началась цепочка: {maxStartIndex}");
    }
}
