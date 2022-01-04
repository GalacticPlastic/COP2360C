using System;

namespace WeightedAverage
{
    class Program
    {
        // Example to calculate average of 5 scores.
        static void Main(string[] args)
        {
            // Pseudo-Code:
            // Write a program that computes a weighted average giving the following weights:
            //  HW - 10 %
            //  Projects - 35 %
            //  Quizzes - 10 %
            //  Exams - 30 %
            //  Final Exam - 15 %

            // Do a compile time initialization with the following values:
            //  HW - 97
            //  Projects - 82
            //  Quizzes - 60
            //  Exams - 75,
            //  Final Exam - 80

            // Display all values including Weights, appropriately labeled and formatted.

            int score1 = 90;
            int score2 = 95;
            int score3 = 78;
            int score4 = 86;
            int score5 = 90;


            int total = score1 + score2 + score3 + score4 + score5;
            double average = total / 5;

            // 5. Output average (number) to terminal.
            Console.WriteLine("Total: " + total.ToString());
            Console.WriteLine("Average: " + average.ToString());
            Console.ReadLine();
        }
    }
}
