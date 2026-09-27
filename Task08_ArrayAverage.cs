using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // 8. Average value of an array
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array: " + string.Join(" ", numbers));

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        double average = (double)sum / numbers.Length;

        Console.WriteLine("Average: " + average);
    }
}
