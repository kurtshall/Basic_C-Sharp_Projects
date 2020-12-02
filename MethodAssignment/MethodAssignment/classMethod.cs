using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    public class classMethod
    {
        public classMethod()
        {

        }

        public int addition(int userNum)
        {
            Console.WriteLine("You entered the number: " + userNum);
            int total = userNum + 12;
            return total;
        }

        public int multi(double userNum2)
        {
            Console.WriteLine("You entered the number: " + userNum2);
            int total = Convert.ToInt32(userNum2 * 4);
            return total;
        }

        public int subtract(string userNum3)
        {
            Console.WriteLine("You entered the number: " + userNum3);
            int total = Convert.ToInt32(userNum3) - 2;
            return total;
        }


    }
}
