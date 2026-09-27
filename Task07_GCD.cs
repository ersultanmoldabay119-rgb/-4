using System;

class Program
{
    static void Main(string[] args)
    {
        // 7. GCD of two numbers
        Console.Write("First number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        int b = int.Parse(Console.ReadLine());

        int x = a;
        int y = b;
        while (y != 0)
        {
            int remainder = x % y;
            x = y;
            y = remainder;
        }

        Console.WriteLine("GCD: " + x);
    }
}
