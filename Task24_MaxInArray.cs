using System;

class Program
{
    static void Main(string[] args)
    {
        // 9. Maximum number in an array
        int[] numbers = { 10, 5, 27, 3, 15 };
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("Numbers: " + string.Join(" ", numbers));
        Console.WriteLine("Maximum number: " + max);
    }
}
