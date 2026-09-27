using System;

class Program
{
    static void Main(string[] args)
    {
        // 5. Prime number check
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

        Console.WriteLine(isPrime ? "The number is prime" : "The number is not prime");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

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
