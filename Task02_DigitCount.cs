using System;

class Program
{
    static void Main(string[] args)
    {
        // 2. Number of digits in a number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        number = Math.Abs(number);

        int count;
        if (number == 0)
        {
            count = 1;
        }
        else
        {
            count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
        }

        Console.WriteLine("Digit count: " + count);
    }
}
