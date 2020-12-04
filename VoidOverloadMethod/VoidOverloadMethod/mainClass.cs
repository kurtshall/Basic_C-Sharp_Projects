using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidOverloadMethod
{
    public static class mainClass
    {
        
        
        public static void mainDiv(int input)
        {
            Console.WriteLine("The number you entered is: " + input);
            int temp = input / 2;
            Console.WriteLine(input + " / 2 = " + temp);
        }

        public static void mainDiv(int input, out int output)
        {

            output = input / 3;
        }


    }
}
