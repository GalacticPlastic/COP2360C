using System;
using System.Collections;

namespace HomeworkAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            /* Solve the following problems using C#.
             * Make sure that the program has well written comments,
             * well formatted outputs and appropriate prompts to the user
             * to get full credit.

             * 1. Write a program that computes the sum of the integers
             * from 1 up to an integer provided by the program's user.
             * For example, if the user types 10, the program should reply
             * 55 because 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55. */

            string inputNumber;
            int userNumber;
            

            Console.WriteLine("Please enter a number:");
            inputNumber = Console.ReadLine();
            userNumber = int.Parse(inputNumber);

            int sum = 0;
            int i = 0;
            while (sum < userNumber)
            {
                sum = sum + i;
                i++;
                if (sum < userNumber)
                {
                    Console.Write(" + {0}", i);
                }
                else
                {
                    Console.Write(" = " + sum);
                }
            }

            /* 2. Write a program that asks the user for a lowercase string
             * and then print its equivalent uppercase letters. */

            string inputText;
            string uppercaseText;

            Console.WriteLine("\n\n******************************");
            Console.WriteLine("\nPlease enter a word, any word!");
            inputText = Console.ReadLine();
            uppercaseText = inputText.ToUpper();

            Console.WriteLine("\nYour Word is: " + uppercaseText + "!\n");

            /* 3. Write a program that prompts a menu option to select the options:
             * Club, Diamond, Heart or Spade. Depending on the user selection
             * [c, d, h, or s], print Cub, Diamond, Heart or Spade. */

            string userSelection;
            string userSuit;

            do
            {
                Console.WriteLine("Pick a Suit! (Enter Q to Quit.)\n");
                Console.WriteLine("*******************");
                Console.WriteLine("**   C - Club     *");
                Console.WriteLine("**   D - Diamond  *");
                Console.WriteLine("**   H - Heart    *");
                Console.WriteLine("**   S - Spade    *");
                Console.WriteLine("*******************\n");

                userSelection = Console.ReadLine();
                userSuit = userSelection.ToUpper();

                switch (userSuit)
                {
                    case "C":
                        Console.WriteLine("You selected CLUB.\n");
                        break;
                    case "D":
                        Console.WriteLine("You selected DIAMOND.\n");
                        break;
                    case "H":
                        Console.WriteLine("You selected HEART.\n");
                        break;
                    case "S":
                        Console.WriteLine("You selected SPADE.\n");
                        break;
                    case "Q":
                        Console.WriteLine("Goodbye!\n");
                        break;
                    default:
                        Console.WriteLine("Selection not valid. Please try again.\n");
                        break;
                }
            }
            while (userSuit != "Q");

            /* 4. Write a program to accept their favorite movie names (at least 5)
             * and store them in an array List. Sort the array list and print them. */


            string firstFavoriteMovie;

            ArrayList movies = new ArrayList();
            string newMovie;


            Console.WriteLine("What's your favorite movie?");
            firstFavoriteMovie = Console.ReadLine();

            movies.Insert(0, firstFavoriteMovie);

            do
            {
                Console.WriteLine("\nWhat's your next favorite movie?");
                newMovie = Console.ReadLine();
                movies.Add(newMovie);
            }
            while (movies.Count < 5);

            Console.WriteLine("\nYour Top 5 Favorite Movies:");
            Console.WriteLine("===============");

            int n = 0;
            foreach (Object movie in movies)
                Console.WriteLine(movie);

            movies.Sort();

            Console.WriteLine("\nYour Favorite Movies, in Aplhabetical Order:");
            Console.WriteLine("==============");
            foreach (Object movie in movies)
                Console.WriteLine(movie);

            Console.ReadKey();
        }
    }
}
