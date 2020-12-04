using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an inherit project.");

            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };

            employee.SayName();

            Console.ReadLine();
        }
    }
}
