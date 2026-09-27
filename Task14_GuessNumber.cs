using System;

class Program
{
    static void Main(string[] args)
    {
        // 14. Guess the number - 7 attempts
        int maxAttempts = 7;
        Random random = new Random();
        int secretNumber = random.Next(1, 101);

        bool guessed = false;

        for (int attempt = 1; attempt <= maxAttempts; attempt++)
        {
            Console.Write("Attempt " + attempt + "/" + maxAttempts + ": ");
            int guess = int.Parse(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("You guessed it in " + attempt + " attempts!");
                guessed = true;
                break;
            }
            else if (guess < secretNumber)
            {
                Console.WriteLine("The secret number is greater.");
            }
            else
            {
                Console.WriteLine("The secret number is smaller.");
            }
        }

        if (!guessed)
        {
            Console.WriteLine("You didn't guess it. The secret number was: " + secretNumber);
        }
    }
}
