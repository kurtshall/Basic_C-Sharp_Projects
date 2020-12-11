using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter package weight: ");
            int packWeight = Convert.ToInt32(Console.ReadLine());

            if ( packWeight <= 50)
            {
                Console.WriteLine("Please enter package width: ");
                int packWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package height: ");
                int packHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter package length: ");
                int packLength = Convert.ToInt32(Console.ReadLine());

                int dimtotal = packLength + packHeight + packWidth;

                if (dimtotal <= 50)
                {
                    double cost = (packLength * packHeight * packWidth * packWeight) / 100.00;
                    Console.WriteLine("Your estimated total for shipping this package is: " + cost.ToString("C"));
                    Console.WriteLine("Thank you!");
                }
                else
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }

            Console.ReadLine();
        }
    }
}
