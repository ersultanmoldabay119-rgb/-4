using System;

class Program
{
    static void Main(string[] args)
    {
        // 11. Count vowels in a string
        Console.Write("Enter a string: ");
        string text = Console.ReadLine().ToLower();

        string vowels = "aeiouy";

        int count = 0;
        foreach (char c in text)
        {
            if (vowels.Contains(c.ToString()))
            {
                count++;
            }
        }

        Console.WriteLine("Vowel count: " + count);
    }
}
