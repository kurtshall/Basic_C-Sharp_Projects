using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        class Person
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int ID { get; set; }
        }

        static void Main(string[] args)
        {
            List<Person> employee = new List<Person>
            {
                new Person{firstName = "John", lastName = "Smith", ID = 0 },
                new Person{firstName = "Steve", lastName = "Karl", ID = 1 },
                new Person{firstName = "Joe", lastName = "Dans", ID = 2 },
                new Person{firstName = "Sarah", lastName = "Thomas", ID = 3 },
                new Person{firstName = "Tyler", lastName = "Feral", ID = 4 },
                new Person{firstName = "Ahri", lastName = "Lons", ID = 5 },
                new Person{firstName = "Trina", lastName = "Dalls", ID = 6 },
                new Person{firstName = "Alfa", lastName = "Daves", ID = 7 },
                new Person{firstName = "Joe", lastName = "Kins", ID = 8 },
                new Person{firstName = "Stuert", lastName = "Mayhe", ID = 9 }
            };

            int i = 0;
            List<string> sameEmp = new List<string>();
            foreach (Person person in employee)
            {
                if (person.firstName == "Joe")
                {
                    sameEmp.Add(person.firstName);
                    i++;
                }
            }

            foreach (string x in sameEmp)
            {
                Console.WriteLine(x);
            }


            List<Person> sameEmp2 = employee.Where(x => x.firstName == "Joe").ToList();

            foreach (Person x in sameEmp2)
            {
                Console.WriteLine(x.firstName);
            }

            List<Person> id5 = employee.Where(x => x.ID > 5).ToList();

            foreach (Person x in id5)
            {
                Console.WriteLine(x.firstName);
            }






            Console.ReadLine();

            //List<Person> sameEmp = new List<Person>();
            //foreach (var x in employee)
            //{
            //    if (employee[i].firstName == "Joe")
            //    {
            //        sameEmp.Add(new Person { firstName = employee[i].firstName, lastName = employee[i].lastName, ID = employee[i].ID });
            //    }
            //}


        }

        private static string ToString(Person x)
        {
            throw new NotImplementedException();
        }
    }
}
