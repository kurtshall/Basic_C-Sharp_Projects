using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionHandlesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                int year = DateTime.Now.Year;
                if (age < 1)
                {
                    throw new ArgumentException();
                }

                Console.WriteLine("You were born in " + (year - age) + "!");
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Enter a age that is not negative or 0: ");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong");
                Console.ReadLine();
                return;
            }


            Console.ReadLine();
        }
    }
}
