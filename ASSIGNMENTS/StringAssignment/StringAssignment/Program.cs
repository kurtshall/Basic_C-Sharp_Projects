using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main()
        {

            string fName = "Kurt";
            string lName = "Cutshall";
            string color = "green";

            Console.WriteLine(fName + " " + lName + "\'s favorite color is " + color + "!");
            Console.WriteLine(color.ToUpper());

            StringBuilder sb = new StringBuilder("Hello World!");
            sb.Append(" What a nice day it is outside!");
            sb.Append("\nWe should go for a walk later today.");
            sb.Append("\nI think tomorrow will be another great day!");

            Console.WriteLine(sb);


            Console.ReadLine();
        }
    }
}
