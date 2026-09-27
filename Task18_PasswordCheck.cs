using System;

class Program
{
    static void Main(string[] args)
    {
        // 3. Password check
        string correctPassword = "12345";

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (password == correctPassword)
        {
            Console.WriteLine("Access granted");
        }
        else
        {
            Console.WriteLine("Access denied");
        }
    }
}
