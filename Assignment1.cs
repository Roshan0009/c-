//Assignment C#
//Roshan Lamichhane
//C0916262
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please  enter a whole number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            
            if (number == 0)
            {
                Console.WriteLine("The entered number is zero (and it is even)");
            }
            else
            {
                
                string sign = number > 0 ? "positive" : "negative";

                
                string parity = number % 2 == 0 ? "even" : "odd";

                Console.WriteLine($"The entered number is {sign} and {parity}");
            }
        }
    }
}