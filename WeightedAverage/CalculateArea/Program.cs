using System;

namespace CalculateArea
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
            string inputLength;
            string inputWidth;
            double area;

            // 1. Get Inputs
            Console.WriteLine("Please enter the length of the rectangle:");
            inputLength = Console.ReadLine();

            Console.WriteLine("Please enter the width of the rectangle:");
            inputWidth = Console.ReadLine();

            // 2. Process
            area = double.Parse(inputLength) * double.Parse(inputWidth);

            // 3. Output
            Console.WriteLine("The area of the rectangle is: {0}", area.ToString("00.00"));
        }
    }
}
