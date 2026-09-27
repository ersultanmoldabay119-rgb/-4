using System;

class Program
{
    static void Main(string[] args)
    {
        // 6. All prime numbers up to N
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (int number = 2; number <= n; number++)
        {
            if (IsPrime(number))
            {
                Console.Write(number + " ");
            }
        }
        Console.WriteLine();
    }

    static bool IsPrime(int number)
    {
        for (int divisor = 2; divisor * divisor <= number; divisor++)
        {
            if (number % divisor == 0)
            {
                return false;
            }
        }

        return true;
    }
}
