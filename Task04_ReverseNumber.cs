using System;

class Program
{
    static void Main(string[] args)
    {
        // 4. Reverse a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isNegative = number < 0;
        number = Math.Abs(number);

        long reversed = 0;
        while (number != 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        if (isNegative)
        {
            reversed = -reversed;
        }

        Console.WriteLine("Reversed number: " + reversed);
    }
}
