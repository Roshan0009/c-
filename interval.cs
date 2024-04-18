//#2 Assignment C#
//Roshan Lamichhane
//C0916262
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] testValues = new double[] { -20, -10, -2, -1, 0, 1, 1.5, 2, 3, 4 };

            foreach (double x in testValues)
            {
                // Check if x belongs to I using only comparator operators and logical operators
                bool isInInterval = (x >= 2 && x < 3) || (x > 0 && x <= 1) || (x >= -10 && x <= -2);

                // Display the result for each test value
                Console.Write($"Enter a real number : {x} ");
                if (isInInterval)
                {
                    Console.WriteLine("x belongs to I");
                    Console.WriteLine("....");
                }
                else
                {
                    Console.WriteLine("x does not belong to I");
                    Console.WriteLine("....");
                }
            }
        }
    }
}
