using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Factorial of a number
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine("Factorial: " + result);
    }
}
