using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2Numbers
{
    public class classOne
    {
        public classOne()
        {

        }

        public int addition(int userNum1, int userNum2 = 3)
        {
            Console.WriteLine("The first number is: " + userNum1 + " and the optional second number is: " + userNum2);
            int total = userNum1 + 7 + userNum2;
            Console.WriteLine(userNum1 + " + 7 + " + userNum2 + " = " + total);
            return total;

        }
    }
}
