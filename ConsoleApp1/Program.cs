using System;

class Program
{
    static void Main()
    {
        PrintMessage("Hello");
        PrintMessage("Hello", 3);
    }

    static void PrintMessage(string message, int repeat = 1)
    {
        for (int i = 0; i < repeat; i++)
        {
            Console.WriteLine(message);
        }
    }
}
