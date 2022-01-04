using System;

namespace ExamPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Trip object by instantiating the class (15 Points)
            // Store sample data in the class object (15 Points)
            Trip myTrip = new Trip();

            myTrip.TravelDate = new DateTime(2021, 03, 21);
            myTrip.Destination = "Orlando";
            myTrip.DistanceTraveled = 260;
            myTrip.GasolineTotalCost = 50;
            myTrip.GallonsConsumed = 10;

            double mpg = myTrip.DistanceTraveled / myTrip.GallonsConsumed;
            double averageGasPrice = myTrip.GasolineTotalCost / myTrip.GallonsConsumed;

            Console.WriteLine("Trip Details");
            Console.WriteLine("**********************************");
            Console.WriteLine("Travel Date:\t\t" + myTrip.TravelDate);
            Console.WriteLine("Total Distance:\t\t" + myTrip.DistanceTraveled + " miles");
            Console.WriteLine("Total Gasoline Cost:\t$" + myTrip.GasolineTotalCost);
            Console.WriteLine("Total Gallons Used:\t" + myTrip.GallonsConsumed);
            Console.WriteLine("**********************************\n");

            Console.WriteLine("The MPG for your trip is " + mpg + ".");
            Console.WriteLine("Gas was roughly $" + averageGasPrice + " per gallon.");

            Console.ReadKey();
        }
    }
}
