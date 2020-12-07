using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumChallenge
{
    class Program
    {
        public enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current day of the week: ");
            string userDay = Console.ReadLine();

            Week day;
            try
            {
                day = (Week)Enum.Parse(typeof(Week), userDay);
                Console.WriteLine("It worked");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.WriteLine(ex.Message);

                
            }

            




            Console.ReadLine();

        }
       
        
    }
}
