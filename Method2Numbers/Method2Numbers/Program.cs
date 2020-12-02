using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2Numbers
{
    class Program
    {
        

        static void Main(string[] args)
        {

            classOne classOne = new classOne();
            Console.WriteLine("Please enter one number and a optional second number.");
            Console.WriteLine("Number one: ");
            int userNum2;
            int result;
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Optional number two: ");
            if (int.TryParse(Console.ReadLine(), out userNum2))
                result = classOne.addition(userNum1, userNum2);
            else
                result = classOne.addition(userNum1);



            Console.ReadLine();

        }
    }
}
