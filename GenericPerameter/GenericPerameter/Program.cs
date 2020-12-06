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

            employee.things = new List<string>() ;



            Employee<int> employee2 = new Employee<int>();

            employee2.things = new List<int>();
            


        }
    }
}
