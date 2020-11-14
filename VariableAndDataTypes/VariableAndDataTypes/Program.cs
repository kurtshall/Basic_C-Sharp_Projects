using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();
            

            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 5;
            Console.WriteLine("Your favorite number is: " + total);
            Console.ReadLine();
            

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char questionMark = '\u2103';
            */

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report.");


            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pageNumber = Convert.ToInt32(page);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool needHelp = Convert.ToBoolean(help);

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experience = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string anythingElse = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int totalHours = Convert.ToInt32(hours);



            Console.WriteLine("Your name is: " + yourName);
            Console.WriteLine("You are on course: " + course);
            Console.WriteLine("You are on page: " + pageNumber);
            Console.WriteLine("Do you need help: " + needHelp);
            Console.WriteLine("Experience: " + experience);
            Console.WriteLine("Anything Else: " + anythingElse);
            Console.WriteLine("Hours: " + totalHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();



        }
    }
}
