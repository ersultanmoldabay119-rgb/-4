using System;

class Program
{
    static void Main(string[] args)
    {
        // 13. Rock, Paper, Scissors
        string[] options = { "Rock", "Scissors", "Paper" };

        Console.Write("Choose (Rock/Scissors/Paper): ");
        string userChoice = Console.ReadLine().Trim();

        Random random = new Random();
        string computerChoice = options[random.Next(options.Length)];

        Console.WriteLine("Your choice: " + userChoice);
        Console.WriteLine("Computer: " + computerChoice);

        if (userChoice.Equals(computerChoice, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("It's a tie!");
        }
        else if (
            (userChoice.Equals("Rock", StringComparison.OrdinalIgnoreCase) && computerChoice == "Scissors") ||
            (userChoice.Equals("Scissors", StringComparison.OrdinalIgnoreCase) && computerChoice == "Paper") ||
            (userChoice.Equals("Paper", StringComparison.OrdinalIgnoreCase) && computerChoice == "Rock"))
        {
            Console.WriteLine("You won!");
        }
        else
        {
            Console.WriteLine("Computer won!");
        }
    }
}
