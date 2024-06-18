using System;

class Program
{
    static void Main()
    {
        // Initialize variables for counting and summing grades
        int count = 0;
        double sum = 0.0;

        // Read grades from user input
        Console.WriteLine("Please enter 21 grades:");

        while (count < 21)
        {
            Console.Write($"Grade {count + 1}: ");
            if (double.TryParse(Console.ReadLine(), out double grade))
            {
                // Check if the grade is valid (between 2.00 and 6.00)
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

        // Calculate the average grade
        double average = sum / 21;

        // Display the result
        Console.WriteLine($"Average grade: {average:F2}");
    }
}

