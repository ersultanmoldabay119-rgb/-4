using System;

class Program
{
    static void Main(string[] args)
    {
        // 5. Even numbers only
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
