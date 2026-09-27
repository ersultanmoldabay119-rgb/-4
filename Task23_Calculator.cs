using System;

class Program
{
    static void Main(string[] args)
    {
        // 8. Simple calculator
        Console.Write("First number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Operation: ");
        string operation = Console.ReadLine();

        double result;

        if (operation == "+")
        {
            result = a + b;
        }
        else if (operation == "-")
        {
            result = a - b;
        }
        else if (operation == "*")
        {
            result = a * b;
        }
        else if (operation == "/")
        {
            if (b == 0)
            {
                Console.WriteLine("Error: division by zero");
                return;
            }
            result = a / b;
        }
        else
        {
            Console.WriteLine("Unknown operation");
            return;
        }

        Console.WriteLine("Result: " + result);
    }
}
