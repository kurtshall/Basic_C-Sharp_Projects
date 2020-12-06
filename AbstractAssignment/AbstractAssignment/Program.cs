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
            
            Employee employee1 = new Employee() { ID = 5 };
            Employee employee2 = new Employee() { ID = 5 };

            Employee employee3 = new Employee() { ID = 6 };
            Employee employee4 = new Employee() { ID = 7 };

            bool b1 = employee1 == employee2;
            bool b2 = employee3 == employee4;


            Console.WriteLine(b1);
            Console.WriteLine(b2);


            Console.ReadLine();
        }
    }
}
