// reference parameter

using System;

class Program
{
    static void Main()
    {
        int x = 10;
        ModifyValue(ref x);
        Console.WriteLine("Value after method call: " + x);  // Output: 20
    }

    static void ModifyValue(ref int a)
    {
        a = 20;
    }
}
