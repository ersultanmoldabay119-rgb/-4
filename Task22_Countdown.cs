using System;

class Program
{
    static void Main(string[] args)
    {
        // 7. Countdown
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Start!");
    }
}
