using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        

        public abstract string SayName();


        
        //public static bool operator ==(Person a, Person b)
        //{
        //    Console.WriteLine("They are the same id");
        //    return a.Equals(b);
        //}

        //public static bool operator !=(Person a, Person b)
        //{
        //    Console.WriteLine("They are not the same id");
        //    return a.Equals(b);
        //}

        //public static bool Equals(Person a, Person b)
        //{
        //    return a.Equals(b);
        //}
    }
}
