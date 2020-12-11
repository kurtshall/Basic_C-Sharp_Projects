using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            classMethod classMethod = new classMethod();


            Console.WriteLine("Please enter a number to do addition on: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            int equal = classMethod.addition(userNum);
            Console.WriteLine(userNum + " + 12 = " + equal);


            Console.WriteLine("Please enter a number to do multiplication on: ");
            double userNum2 = Convert.ToDouble(Console.ReadLine());

            int equal2 = classMethod.multi(userNum2);
            Console.WriteLine(userNum2 + " * 4 = " + equal2);


            Console.WriteLine("Please enter a number to do subtraction on: ");
            string userNum3 = Console.ReadLine();

            int equal3 = classMethod.subtract(userNum3);
            Console.WriteLine(userNum3 + " - 2 = " + equal3);




            Console.ReadLine();

        }
    }
}
