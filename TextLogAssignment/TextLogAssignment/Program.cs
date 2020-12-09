using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextLogAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to save to a log file: ");
            string userNum = Console.ReadLine();

            File.WriteAllText(@"C:\Users\Kurt\Desktop\Logs", userNum);

            string text = File.ReadAllText(@"C:\Users\Kurt\Desktop\Logs");
            Console.WriteLine(text);

            Console.ReadLine();

        }
    }
}
