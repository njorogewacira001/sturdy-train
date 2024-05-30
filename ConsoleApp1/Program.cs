// parameter Array

using System;

class Program
{
    static void Main()
    {
        PrintNumbers(1, 2, 3, 4, 5);
    }

    static void PrintNumbers(params int[] numbers)
    {
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
