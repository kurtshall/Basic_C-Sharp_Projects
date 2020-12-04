using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a number to be divided by 2.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            mainClass.mainDiv(userNum);

            int a;
            mainClass.mainDiv(userNum, out a);

            Console.WriteLine(userNum + " / 3 = " + a);

            Console.ReadLine();


        }
    }
}
