//output parameter

using System;

class Program
{
    static void Main()
    {
        int result;
        bool success = TryParse("123", out result);
        Console.WriteLine("Parsing success: " + success + ", Result: " + result);  // Output: Parsing success: True, Result: 123
    }

    static bool TryParse(string input, out int number)
    {
        return int.TryParse(input, out number);
    }
}
