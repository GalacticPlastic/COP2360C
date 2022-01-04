using System;

namespace MenuPrompt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the Area of a Circle
            Console.WriteLine("Select from the following options:");
            Console.WriteLine("**********************************");
            CalculateArea();
        }

        static void CalculateArea()
        {
            string menuSelection;
            int inputShape;

            Console.WriteLine("1 - Circle\n2 - Rectangle\n3 - Square\n**********************************");
            menuSelection = Console.ReadLine();
            inputShape = int.Parse(menuSelection);

            switch (inputShape)
            {
                case 1:
                    CalculateCircle();
                    break;
                case 2:
                    CalculateRectangle();
                    break;
                case 3:
                    CalculateSquare();
                    break;
                default:
                    Console.WriteLine("Your selection is incorrect.");
                    break;
            }
        }

        static void CalculateCircle()
        {
            string inputRadius;
            double areaCircle;

            // 1. Get Inputs
            Console.WriteLine("Please enter the radius of the circle:");
            inputRadius = Console.ReadLine();


            // 2. Process
            areaCircle = Math.Pow(double.Parse(inputRadius), 2) * Math.PI;

            // 3. Output
            Console.WriteLine("The area of the cricle is: {0}", areaCircle.ToString("00.00"));
            Console.Read();
        }

        static void CalculateRectangle()
        {
            string inputLength;
            string inputWidth;
            double areaRectangle;

            // 1. Get Inputs
            Console.WriteLine("Please enter the length of the rectangle:");
            inputLength = Console.ReadLine();

            Console.WriteLine("Please enter the width of the rectangle:");
            inputWidth = Console.ReadLine();


            // 2. Process
            areaRectangle = double.Parse(inputLength) * double.Parse(inputWidth);

            // 3. Output
            Console.WriteLine("The area of the rectangle is: {0}", areaRectangle.ToString("00.00"));
            Console.Read();
        }
        static void CalculateSquare()
        {
            string inputSide;
            double areaSquare;

            // 1. Get Inputs
            Console.WriteLine("Please enter the side length of the square:");
            inputSide = Console.ReadLine();


            // 2. Process
            areaSquare = Math.Pow(double.Parse(inputSide), 2);

            // 3. Output
            Console.WriteLine("The area of the square is: {0}", areaSquare.ToString("00.00"));
            Console.Read();
        }
    }
}
