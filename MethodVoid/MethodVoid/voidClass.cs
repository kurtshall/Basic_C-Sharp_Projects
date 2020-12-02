using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodVoid
{
    public class voidClass
    {
        public voidClass()
        {

        }

        public void oper(int numOne, int numTwo)
        {
            Console.WriteLine("You entered for number one: " + numOne + " and for number two: " + numTwo);
            int total = numOne + 7;
            Console.WriteLine(numOne + " + 7 = " + total);
            Console.WriteLine(numTwo + " is your second number!");

        }
    }
}
