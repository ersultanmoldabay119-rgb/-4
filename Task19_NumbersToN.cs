using System;

class Program
{
    static void Main(string[] args)
    {
        // 4. Numbers from 1 to N
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
