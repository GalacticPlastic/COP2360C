using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            while loop - Print 1 to 10
            int i = 0;

            while (i < 11)
            {
               Console.WriteLine(i);
               i = i + 1;
            }

            for (int j = 1; j < 11; j++)
            {
               Console.WriteLine(j);
            }

            int k = 0;

            do
            {
                Console.WriteLine(k);
                k++;
            } while (k < 11);

            string strVal = "Broward";

            Console.ReadKey();
        }
    }
}
