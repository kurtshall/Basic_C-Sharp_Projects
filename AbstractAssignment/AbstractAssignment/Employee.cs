using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public class Employee : Person
    {
        public override string SayName()
        {
            Console.WriteLine("Hello my name is " + firstName + " " + LastName);
            throw new NotImplementedException();
        }
    }
}
