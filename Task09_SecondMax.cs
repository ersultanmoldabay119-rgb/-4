using System;

class Program
{
    static void Main(string[] args)
    {
        // 9. Second maximum number in an array
        int[] numbers = { 15, 8, 27, 10, 21 };

        Console.WriteLine("Array: " + string.Join(" ", numbers));

        int max = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                secondMax = max;
                max = number;
            }
            else if (number > secondMax && number != max)
            {
                secondMax = number;
            }
        }

        Console.WriteLine("Second maximum: " + secondMax);
    }
}
