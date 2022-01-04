using System;

namespace RockPaperScissors
{
    public class Tool
    {
        static void Main(string[] args)
        {
            /* Implement a class called Tool. It should have an int field called strength
             * and a char field called type. You may make them either private or protected.
             * The Tool class should also contain the function void setStrength(int),
             * which sets the strength for the Tool. */


            string replay = "";
            int userWins = 0;
            int computerWins = 0;

            Console.WriteLine("Let's play Rock, Paper, Scissors!\n");
            Console.WriteLine("First, set the default strengths.");
            Console.WriteLine("Rock? (Enter number.)");
            Console.WriteLine("Paper? (Enter number.)");


            while (replay != "n")
            {
                Console.WriteLine("Pick your play: r, p, s\n");

                string[] computersTurn = new string[3] { "r", "p", "s" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);

                string user = Console.ReadLine().ToLower();

                Console.WriteLine("\nComputer:\t" + computersTurn[n]);

                if (user == "r" && computersTurn[n] == "s")
                {
                    Console.WriteLine("You win!");
                    userWins += 1;
                }
                else if (user == "r" && computersTurn[n] == "p")
                {
                    Console.WriteLine("Computer wins.");
                    computerWins += 1;
                }
                else if (user == "p" && computersTurn[n] == "r")
                {
                    Console.WriteLine("You win!");
                    userWins += 1;
                }
                else if (user == "p" && computersTurn[n] == "s")
                {
                    Console.WriteLine("Computer Wins.");
                    computerWins += 1;
                }
                else if (user == "s" && computersTurn[n] == "r")
                {
                    Console.WriteLine("Computer Wins.");
                    computerWins += 1;
                }
                else if (user == "s" && computersTurn[n] == "p")
                {
                    Console.WriteLine("You win!");
                    userWins += 1;
                }
                else
                {
                    Console.WriteLine("Tie!");
                }
                Console.WriteLine("-----------------");
                Console.WriteLine("Play again? Y/N");
                replay = Console.ReadLine().ToLower();
                Console.WriteLine("\n-----------------------");
            }
            Console.WriteLine("You won:\t" + userWins);
            Console.WriteLine("Computer won:\t" + computerWins);
        }
    }
}