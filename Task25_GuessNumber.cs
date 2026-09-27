using System;

class Program
{
    static void Main(string[] args)
    {
        // 10. Guess the number (repeat until guessed)
        int secret = 7;

        while (true)
        {
            Console.Write("Guess the number: ");
            int guess = int.Parse(Console.ReadLine());

            if (guess < secret)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > secret)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                break;
            }
        }
    }
}
