//using System;

//namespace RockPaperScissors
//{
//    public class PlayGame
//    {
//        static void Main()
//        {
//            Console.WriteLine("Let's play Rock, Paper, Scissors!\n");

//            new Tool();
//            Console.WriteLine("\nOkay. Time to play!\n");
//            Console.WriteLine("==================");

//        }

//        public class Tool
//        {
//            static void Main()
//            {
//            /* implement a class called Tool. It should have an int field called strength
//             * and a char field called type. You may make them either private or protected.
//             * The Tool class should also contain the function void setStrength(int),
//             * which sets the strength for the Tool. */

//            private int Strength { get; set; }
//            private string Type Act();

//            string replay = "";
//            int userWins = 0;
//            int computerWins = 0;

//            //strengthRock;
//            //strengthPaper;
//            //strengthScissors;




//            //while (replay != "n")
//            //{
//            //    Console.WriteLine("Pick your play: r, p, s\n");

//            //    string[] computersTurn = new string[3] { "r", "p", "s" };
//            //    Random rnd = new Random();
//            //    int n = rnd.Next(0, 3);

//            //    string user = Console.ReadLine().ToLower();

//            //    Console.WriteLine("\nComputer:\t" + computersTurn[n]);

//            //    if (user == "r" && computersTurn[n] == "s")
//            //    {
//            //        Console.WriteLine("You win!");
//            //        userWins += 1;
//            //    }
//            //    else if (user == "r" && computersTurn[n] == "p")
//            //    {
//            //        Console.WriteLine("Computer wins.");
//            //        computerWins += 1;
//            //    }
//            //    else if (user == "p" && computersTurn[n] == "r")
//            //    {
//            //        Console.WriteLine("You win!");
//            //        userWins += 1;
//            //    }
//            //    else if (user == "p" && computersTurn[n] == "s")
//            //    {
//            //        Console.WriteLine("Computer Wins.");
//            //        computerWins += 1;
//            //    }
//            //    else if (user == "s" && computersTurn[n] == "r")
//            //    {
//            //        Console.WriteLine("Computer Wins.");
//            //        computerWins += 1;
//            //    }
//            //    else if (user == "s" && computersTurn[n] == "p")
//            //    {
//            //        Console.WriteLine("You win!");
//            //        userWins += 1;
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Tie!");
//            //    }
//            //    Console.WriteLine("-----------------");
//            //    Console.WriteLine("Play again? Y/N");
//            //    replay = Console.ReadLine().ToLower();
//            //    Console.WriteLine("\n-----------------------");
//            //}
//            //Console.WriteLine("You won:\t" + userWins);
//            //Console.WriteLine("Computer won:\t" + computerWins);
//        }

//        //static void setStrength(int)
//        //{
//        //    Console.WriteLine("First, set the default strengths.");
//        //    Console.WriteLine("Rock? (Enter number.)");
//        //    Console.WriteLine("Paper? (Enter number.)");
//        //    Console.WriteLine("Scissors? (Enter number.)");
//        //}
//    }

//    public class Rock : Tool
//    {
//        // Constructor that takes one argument:
//        public r(int rockDefaultStrength)
//        {
//            type = "r";
//            strength = rockDefaultStrength;
//        }
//        public override GameAction Act()
//        {
//            return GameAction.Rock;
//        }
//    }

//    public class Paper : Tool
//    {
//        // Constructor that takes one argument:
//        public r(int paperDefaultStrength)
//        {
//            type = "p";
//            strength = paperDefaultStrength;
//        }
//    }

//    public class Scissors : Tool
//    {
//        // Constructor that takes one argument:
//        public s(int strength)
//        {
//            Name = name;
//        }
//    }
//}