using System;

class Program
{
    static void Main(string[] args)
    {
        // 12. Palindrome check
        Console.Write("Enter a word: ");
        string text = Console.ReadLine().ToLower();

        bool isPalindrome = true;
        for (int i = 0; i < text.Length / 2; i++)
        {
            if (text[i] != text[text.Length - 1 - i])
            {
                isPalindrome = false;
                break;
            }
        }

        Console.WriteLine(isPalindrome ? "Palindrome" : "Not a palindrome");
    }
}
