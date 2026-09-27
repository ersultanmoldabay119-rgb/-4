using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Positive, negative or zero
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("The number is positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("The number is negative");
        }
        else
        {
            Console.WriteLine("The number is zero");
        }
    }
}
