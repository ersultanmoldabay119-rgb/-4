using System;

class Program
{
    static void Main(string[] args)
    {
        // 3. Sum of digits of a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        number = Math.Abs(number);

        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine("Digit sum: " + sum);
    }
}
