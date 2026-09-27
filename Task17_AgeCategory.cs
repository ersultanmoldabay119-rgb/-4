using System;

class Program
{
    static void Main(string[] args)
    {
        // 2. User age category
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 12)
        {
            Console.WriteLine("You are a child");
        }
        else if (age < 18)
        {
            Console.WriteLine("You are a teenager");
        }
        else
        {
            Console.WriteLine("You are an adult");
        }
    }
}
