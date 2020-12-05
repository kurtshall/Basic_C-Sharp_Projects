using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public class Employee : Person, IQuittable
    {

        void IQuittable.Quit()
        {
            
            throw new NotImplementedException();
        }

        public override string SayName()
        {
            Console.WriteLine("Hello my name is " + firstName + " " + LastName);

            throw new NotImplementedException();
        }

        internal void Quit()
        {
            Console.WriteLine(firstName + " " + LastName + " just quit.");
            
        }
    }
}
