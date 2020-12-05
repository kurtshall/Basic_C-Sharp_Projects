using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is going over abstract classes.");

            Employee employee = new Employee() { firstName = "Sample", LastName = "Student" };
            employee.Quit();
            //employee.SayName();
            


            Console.ReadLine();
        }
    }
}
