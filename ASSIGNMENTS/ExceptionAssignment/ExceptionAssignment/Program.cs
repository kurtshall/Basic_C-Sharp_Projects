using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                List<int> numbers = new List<int>();
                numbers.Add(18);
                numbers.Add(23);
                numbers.Add(41);
                numbers.Add(70);
                numbers.Add(95);
                Console.WriteLine("Enter a number to divide by in the list of: 18, 23, 41, 70, 95: ");
                int guestNum = Convert.ToInt32(Console.ReadLine());


                for (int j = 0; j < numbers.Count; j++)
                {
                    int numTotal = 1;
                    numTotal = numbers[j] / guestNum;
                    Console.WriteLine(numbers[j] + " divided by " + guestNum + " = " + numTotal);

                }
                
            }
            

            catch (Exception ex)
            {
                Console.WriteLine("Catch stage");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finale stage");
                Console.ReadLine();
            }


        }
    }
}
