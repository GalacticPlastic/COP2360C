using System;

namespace WeightedAverage
{
    class Program
    {
        static void Main(string[] args)
        {
			// Write a program that computes a weighted average giving the following weights:
			//	HW - 10%,	Projects - 35%,	Quizzes - 10%, Exams - 30%,	Final Exam - 15%
			int WeightedHomework = 10;
			int WeightedProjects = 35;
			int WeightedQuizzes = 10;
			int WeightedExams = 30;
			int WeightedFinal = 15;

			// Do a compile time initialization with the following values:
			// HW - 97,	Projects - 82,	Quizzes - 60,	Exams - 75,	Final Exam - 80
			int HomeworkGrade = 97;
			int ProjectGrade = 82;
			int QuizGrade = 60;
			int ExamGrade = 75;
			int FinalGrade = 80;

			// Display all values including Weights, appropriately labeled and formatted.
			double totalGrades = (WeightedHomework * HomeworkGrade)
								 + (WeightedProjects * ProjectGrade)
								 + (WeightedQuizzes * QuizGrade)
								 + (WeightedExams * ExamGrade)
								 + (WeightedFinal * FinalGrade);

			double WeightedSum = WeightedHomework
								 + WeightedProjects
								 + WeightedQuizzes
								 + WeightedExams
								 + WeightedFinal;

			double weightedAverage = totalGrades / WeightedSum;

			string LetterGrade;

			if (weightedAverage >= 90)
			{
				LetterGrade = "A";
			}
            else if (weightedAverage >= 80)
			{
				LetterGrade = "B";
			}
			else if (weightedAverage >= 70)
			{
				LetterGrade = "C";
			}
			else if (weightedAverage >= 60)
			{
				LetterGrade = "D";
			}
			else
			{
				LetterGrade = "F";
			}

			Console.WriteLine($"Homework:\t{HomeworkGrade}\t({WeightedHomework}% of Grade)");
			Console.WriteLine($"Projects:\t{ProjectGrade}\t({WeightedProjects}% of Grade)");
			Console.WriteLine($"Quizzes:\t{QuizGrade}\t({WeightedQuizzes}% of Grade)");
			Console.WriteLine($"Exams:\t\t{ExamGrade}\t({WeightedExams}% of Grade)");
			Console.WriteLine($"Final:\t\t{FinalGrade}\t({WeightedFinal}% of Grade)");

			Console.WriteLine("======================================");
			Console.WriteLine($"Weighted AVG:\t{weightedAverage}\t{LetterGrade}");
			Console.ReadKey();
		}
    }
}
