using System;

namespace ClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create ExamScore object using class ExamScore.
            ExamScore examScore = new ExamScore();

            examScore.StudentId = 1000;
            examScore.Score1 = 80;
            examScore.Score2 = 81;
            examScore.Score3 = 82;

            double average = (examScore.Score1 + examScore.Score2 + examScore.Score3) / 3;
            char grade = ' ';

            Console.WriteLine("The average of your scores is: " + average);

            // One-Way If Statement
            if (average > 89)
            {
                Console.WriteLine("Your grade is an A.");
            }

            // Two-Way If Statements
            if (average > 89)
            {
                Console.WriteLine("Your grade is an A.");
            }
            else
            {
                Console.WriteLine("Your grade is not an A.");
            }

            // Nested If Statements
            if (average > 89)
            {
                grade = 'A';
                Console.WriteLine("Your grade is an A.");
            }
            else
            {
                if (average <= 89 && average > 79)
                {
                    grade = 'B';
                    Console.WriteLine("Your grade is a B.");
                }
                else
                {
                    if (average <= 79 && average > 69)
                    {
                        grade = 'C';
                        Console.WriteLine("Your grade is a C.");
                    }
                }
            }

            // Switch Statement
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Your grade is an A.");
                    break;
                case 'B':
                    Console.WriteLine("Your grade is a B.");
                    break;
                case 'C':
                    Console.WriteLine("Your grade is a C.");
                    break;
                case 'D':
                    Console.WriteLine("Your grade is a D.");
                    break;
                case 'F':
                    Console.WriteLine("Your grade is an F.");
                    break;
                default:
                    Console.WriteLine("Your grade is unavailable.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
