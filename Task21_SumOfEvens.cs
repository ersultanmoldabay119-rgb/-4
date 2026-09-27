using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // 6. Sum of even numbers
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        var terms = new StringBuilder();

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;

                if (terms.Length > 0)
                {
                    terms.Append(" + ");
                }
                terms.Append(i);
            }
        }

        Console.WriteLine($"{terms} = {sum}");
        Console.WriteLine("Sum: " + sum);
    }
}
