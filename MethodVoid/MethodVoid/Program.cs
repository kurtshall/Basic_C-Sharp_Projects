using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodVoid
{
    class Program
    {
        static void Main(string[] args)
        {
            voidClass voidClass = new voidClass();

            Console.WriteLine("Please enter two numbers into the system.");
            Console.WriteLine("Number one: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number two: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            voidClass.oper(numOne, numTwo);

            Console.ReadLine();

        }
    }
}
