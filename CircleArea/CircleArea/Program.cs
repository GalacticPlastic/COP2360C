using System;


namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculate the Area of a Circle
            DisplayHeader();
            CalculateArea();
            DisplayHeader();
        }

        static void DisplayHeader()
        {
            Console.WriteLine("******************");
        }

        static void CalculateArea()
        {
            string inputRadius;
            double area;

            // 1. Get Inputs
            Console.WriteLine("Please enter the radius of the circle:");
            inputRadius = Console.ReadLine();


            // 2. Process
            area = double.Parse(inputRadius) * Math.Pow(inputRadius, 2) * Math.PI;

            // 3. Output
            Console.WriteLine("The area of the cricle is: {0}", area.ToString("00.00"));
            Console.Read();
        }

        private int
    }
}
