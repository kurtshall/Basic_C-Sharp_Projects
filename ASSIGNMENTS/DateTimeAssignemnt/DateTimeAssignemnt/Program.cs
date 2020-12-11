using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignemnt
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine());

            DateTime today = DateTime.Now;
            DateTime total = today.AddHours(userNum);
            Console.WriteLine(total);

            
           

            Console.ReadLine();
        }
    }
}
