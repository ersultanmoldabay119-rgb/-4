using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // 15. Mini student system
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("How many students to enter: ");
        int studentCount = int.Parse(Console.ReadLine());

        string[] names = new string[studentCount];
        double[] grades = new double[studentCount];

        for (int i = 0; i < studentCount; i++)
        {
            Console.Write("Student " + (i + 1) + " name: ");
            names[i] = Console.ReadLine();

            Console.Write("Student " + (i + 1) + " grade: ");
            grades[i] = double.Parse(Console.ReadLine());
        }

        double sum = 0;
        int bestIndex = 0;
        for (int i = 0; i < studentCount; i++)
        {
            sum += grades[i];
            if (grades[i] > grades[bestIndex])
            {
                bestIndex = i;
            }
        }

        double average = sum / studentCount;

        int aboveAverageCount = 0;
        for (int i = 0; i < studentCount; i++)
        {
            if (grades[i] > average)
            {
                aboveAverageCount++;
            }
        }

        Console.WriteLine();
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine(names[i] + " — " + grades[i]);
        }

        Console.WriteLine();
        Console.WriteLine("Average grade: " + average.ToString("F1"));
        Console.WriteLine("Best student: " + names[bestIndex] + " — " + grades[bestIndex]);
        Console.WriteLine("Above average: " + aboveAverageCount);
    }
}
