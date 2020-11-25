using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStringAssignment
{
    class Program
    {
        static void Main()
        {
            int[] intArray = { 4, 5, 8, 21, 456, 231 };
            string[] stringArray = { "John", "Steve", "Amanda", "Lisa", "Kelly" };

            Console.WriteLine("Pick a number from 0-5 to display an array!");
            int arrayNum = Convert.ToInt32(Console.ReadLine());
            int arrayLength = intArray.Length;

            while (arrayNum > arrayLength || arrayNum < 0)
            {
                Console.WriteLine("You did not enter a number between 0-5, try again:");
                arrayNum = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(intArray[arrayNum]);

            Console.WriteLine("Pick a number from 0-4 to display a Name array!");
            int arrayName = Convert.ToInt32(Console.ReadLine());
            int arrayNameLength = stringArray.Length;


            while (arrayName > arrayNameLength || arrayName < 0)
            {
                Console.WriteLine("You did not enter a number between 0-4, try again:");
                arrayName = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(stringArray[arrayName]);


            List<string> intList = new List<string>();
            intList.Add("Today is Monday");
            intList.Add("Today is Tuesday");
            intList.Add("Today is Wednesday");
            intList.Add("Today is Thursday");
            intList.Add("Today is Friday");

            Console.WriteLine("Pick a number from 0-4 to display a string array!");
            int stringNum = Convert.ToInt32(Console.ReadLine());

            while (stringNum > 4 || stringNum < 0)
            {
                Console.WriteLine("You did not enter a number between 0-4, try again:");
                stringNum = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(intList[stringNum]);



            Console.ReadLine();

        }
    }
}
