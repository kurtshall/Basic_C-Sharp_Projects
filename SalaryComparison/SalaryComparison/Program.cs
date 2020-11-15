using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1:");
            Console.WriteLine("Enter your Hourly Rate:");
            double pers1rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Person 1 Hourly Rate: " + pers1rate.ToString());
            Console.WriteLine("Enter your Hours Worked:");
            int pers1hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 1 Hours Worked: " + pers1hours.ToString());

            Console.WriteLine("Person 2:");
            Console.WriteLine("Enter your Hourly Rate:");
            double pers2rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Person 2 Hourly Rate: " + pers2rate.ToString());
            Console.WriteLine("Enter your Hours Worked:");
            int pers2hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2 Hours Worked: " + pers2hours.ToString());

            double pers1total = pers1rate * pers1hours;
            Console.WriteLine("Annual salary of Person 1: " + pers1total.ToString());
            double pers2total = pers2rate * pers2hours;
            Console.WriteLine("Annual salary of Person 2: " + pers2total.ToString());
            bool check = pers1total > pers2total;
            Console.WriteLine("Does Person 1 make more money than Person 2? " + check.ToString());






            Console.ReadLine();
        }
    }
}
