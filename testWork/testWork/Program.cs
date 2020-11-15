using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testWork
{
    class Program
    {
        static void Main(string[] args)
        {

            //int num1 = 10;
            //int num2 = 2;
            //int addition = num1 + num2;
            //int subtract = num1 - num2;
            //int mult = num1 * num2;
            //int div = num1 / num2;

            //string nameF = "Kurt";
            //string nameL = "Cutshall";



            //Console.WriteLine(nameF + nameL);
            //Console.WriteLine(addition);
            //Console.WriteLine(subtract);
            //Console.WriteLine(mult);
            //Console.WriteLine(div);

            int num1 = 10;
            int num2 = 2;
            string result = num1 > num2 ? "num1 is greater than num2" : "num2 is greater than num1";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
