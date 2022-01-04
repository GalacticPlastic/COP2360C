using System;
using System.Collections;

namespace AddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Print the sum of 1st 10 numbers.
            int i = 0;
            int total = 0;

            while (i < 11)
            {
               total = total + i;
               i++;
            }

            Console.WriteLine("Total is: " + total);
            Console.ReadKey();

            int total = 0;

            for (int j = 0; j < 11; j++)
            {
               total = total + j;
               Console.WriteLine(total);
            }

            // Write a Program to display a menu option to indicate
            // colors and print them based on the user selection using switch.

            // ******************
            // **   B - Blue    *
            // **   R - Red     *
            // **   G - Green   *
            // **   Q - Quit    *
            // ******************

            string userSelection;
            string userColor;

            do
            {
               Console.WriteLine("Pick a Color!\n");
               Console.WriteLine("******************");
               Console.WriteLine("**   B - Blue    *");
               Console.WriteLine("**   R - Red     *");
               Console.WriteLine("**   G - Green   *");
               Console.WriteLine("**   Q - Quit    *");
               Console.WriteLine("******************\n");

               userSelection = Console.ReadLine();
               userColor = userSelection.ToUpper();

               switch (userColor)
               {
                   case "B":
                       Console.WriteLine("You selected BLUE.\n");
                       break;
                   case "R":
                       Console.WriteLine("You selected RED.\n");
                       break;
                   case "G":
                       Console.WriteLine("You selected GREEN.\n");
                       break;
                   case "Q":
                       Console.WriteLine("Goodbye.\n");
                       break;
                   default:
                       Console.WriteLine("Selection not valid. Please try again.\n");
                       break;
               }
            }
            while (userColor != "Q");

            // Array Declaration;
            int[] scores = new int[5];
            scores[0] = 89;
            scores[1] = 90;
            scores[2] = 78;
            scores[3] = 88;
            scores[4] = 98;

            Console.WriteLine("Score 1: " + scores[0]);
            Console.WriteLine("Score 2: " + scores[1]);
            Console.WriteLine("Score 3: " + scores[2]);

            for (int i =0; i < scores.Length; i++)
            {
               Console.WriteLine("Score {0} - {1}", i + 1, scores[i]);
            }

            int[] days = new int[7];
            int[] gymTime = new int[7];

            for (int i = 0; i < 7; i++)
            {
               days[i] = i + 1;
            }

            int counter = 0;
            while (counter < 7)
            {
               Console.WriteLine("\nPlease enter gym time for day {0}:", counter + 1);
               gymTime[counter] = int.Parse(Console.ReadLine());
               counter++;
            }

            Console.WriteLine("Day\tGym Time");
            Console.WriteLine("---\t--------");

            for (int j = 0; j < 7; j++)
            {
               Console.WriteLine(days[j] + "\t" + gymTime[j]);
            }

            // Monthly Rainfall amount for a year.
            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";

            int[] rainfall = new int[12];

            for (int i = 0; i < 12; i++)
            {
               rainfall[i] = i + 1;
            }

            int counter = 0;
            while (counter < 12)
            {
               Console.WriteLine("\nPlease enter the total rainfall for the month of {0}:", counter + 1);
               rainfall[counter] = int.Parse(Console.ReadLine());
               counter++;
            }

            int totalRainfall = 0;

            for (int i = 0; i < months.Length; i++)
            {
                switch (int.Parse(months[i]))
                {
                   case 0:
                       Console.WriteLine("\nPlease enter the total rainfall for the {0}st month:", i + 1, months[i]);
                       break;
                   case 1:
                       Console.WriteLine("\nPlease enter the total rainfall for the {0}nd month:", i + 1, months[i]);
                       break;
                   case 2:
                       Console.WriteLine("\nPlease enter the total rainfall for the {0}rd month:", i + 1, months[i]);
                       break;
                   default:
                       Console.WriteLine("\nPlease enter the total rainfall for the {0}th month:", i + 1, months[i]);
                       break;
                }
               Console.WriteLine("\nEnter total rainfall for {0}:", months[i]);
               rainfall[counter] = int.Parse(Console.ReadLine());
               counter++;
               totalRainfall += rainfall[i];
            }

            Console.WriteLine("Month      \tRainfall");
            Console.WriteLine("=========================");

            for (int j = 0; j < 12; j++)
            {
               Console.WriteLine(months[j].PadRight(15, ' ') + "\t" + rainfall[j]);
            }

            int averageRainfall = totalRainfall / months.Length;

            Console.WriteLine("=========================");
            Console.WriteLine("\nTotal Annual Rainfall: " + totalRainfall + "inches");
            Console.WriteLine("Average Rainfall: " + averageRainfall + "inches");

            string[] names = new string[5] { "John", "Kevin", "Edward", "Mary", "Emily" };

            Console.WriteLine("\nUnsorted Names:");
            Console.WriteLine("===============");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Array.Sort(names);

            Console.WriteLine("\nSorted Names:");
            Console.WriteLine("==============");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            ArrayList myTodoList = new ArrayList();
            myTodoList.Add("Homework - Assignment 2.");
            myTodoList.Add("Attend class.");
            myTodoList.Add("Complete classwork.");
            myTodoList.Add("Share and present classwork.");

            Console.WriteLine("\nTo Do List:");
            Console.WriteLine("============================");

            foreach (string task in myTodoList)
            {
                Console.WriteLine("- " + task);
            }

            Console.ReadKey();
        }
    }
}
