using System;

class Program
{
    static void Main()
    {
        int count = 0;
        double sum = 0.0;

        Console.WriteLine("Please enter 21 grades:");

        while (count < 21)
        {
            Console.Write($"Grade {count + 1}: ");
            if (double.TryParse(Console.ReadLine(), out double grade))
            {
                if (grade >= 2.00 && grade <= 6.00)
                {
                    sum += grade;
                    count++;
                }
                else
                {
                    Console.WriteLine("Grade must be between 2.00 and 6.00. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid grade value. Please try again.");
            }
        }

        double average = sum / 21;
        Console.WriteLine($"Average grade: {average:F2}");
    }
}

