using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number to be multiplied by 50:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int mult = 50 * userNum;
            Console.WriteLine("50 * " + userNum.ToString() + " = " + mult.ToString());

            Console.WriteLine("Enter a number to be added to 25:");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int add = 25 + userNum2;
            Console.WriteLine("50 * " + userNum2.ToString() + " = " + add.ToString());

            Console.WriteLine("Enter a number to be divided by 12.5:");
            double userNum3 = Convert.ToInt32(Console.ReadLine());
            double div = userNum3 / 12.5;
            Console.WriteLine(userNum3.ToString() + " / 12.5 = " + div.ToString());

            Console.WriteLine("Enter a number:");
            int userNum4 = Convert.ToInt32(Console.ReadLine());
            bool check = userNum4 > 50;
            Console.WriteLine("Is " + userNum4.ToString() + " greater than 50: " + check.ToString());

            Console.WriteLine("Enter a number to be divided by 7:");
            int userNum5 = Convert.ToInt32(Console.ReadLine());
            int remain = userNum5 % 7;
            Console.WriteLine(userNum5.ToString() + " remainder after being divided by 7 is: " + remain.ToString());



            Console.ReadLine();


        }
    }
}
