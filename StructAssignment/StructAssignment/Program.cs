using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 3.45M;

            Console.WriteLine("This will print out a decimal:");
            Console.WriteLine(number.Amount);

            Console.ReadLine();


        }
    }
}
