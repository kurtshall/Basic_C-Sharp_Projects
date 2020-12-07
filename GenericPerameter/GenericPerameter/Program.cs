using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPerameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();

            employee.things = new List<string>() { "Hello", "World", "Earth" };



            Employee<int> employee2 = new Employee<int>();

            employee2.things = new List<int>() { 4, 5, 23, 128 };


            foreach (string word in employee.things)
            {
                Console.WriteLine(word);
            }

            foreach (int g in employee2.things)
            {
                Console.WriteLine(g);
            }


            

            Console.ReadLine();
            


        }
    }
}
