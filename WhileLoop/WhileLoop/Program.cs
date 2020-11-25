using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            bool numGuessed = false;
            Console.WriteLine("Guess a number between 1-10.");
            int number = Convert.ToInt32(Console.ReadLine());

            while (numGuessed == false)
            {
                switch (number)
                {
                    case 4:
                        Console.WriteLine("You guess the right number!");
                        numGuessed = true;
                        break;

                    default:
                        Console.WriteLine("You guessed " + number + ", try another number!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }


            bool dayNovGuessed = false;
            Console.WriteLine("Enter a number to see what day it is of the month for November:");
            int dayNov = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (dayNov)
                {
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        Console.WriteLine("Its Sunday, but not a special holiday. Try another day:");
                        dayNov = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                    case 9:
                    case 16:
                    case 23:
                    case 30:
                        Console.WriteLine("Its Monday, but not a special holiday. Try another day:");
                        dayNov = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                    case 10:
                    case 17:
                    case 24:
                        Console.WriteLine("Its Tuesday, but not a special holiday. Try another day:");
                        dayNov = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        Console.WriteLine("Its Wednesday, but not a special holiday. Try another day:");
                        dayNov = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 5:
                    case 12:
                    case 19:
                        Console.WriteLine("Its Thursday, but not a special holiday. Try another day:");
                        dayNov = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 6:
                    case 13:
                    case 20:
                    case 27:
                        Console.WriteLine("Its Friday, but not a special holiday. Try another day:");
                        dayNov = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 7:
                    case 14:
                    case 21:
                    case 28:
                        Console.WriteLine("Its Saturday, but not a special holiday. Try another day:");
                        dayNov = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 26:
                        Console.WriteLine("Its Thanksgiving!");
                        dayNovGuessed = true;
                        break;

                    default:
                        Console.WriteLine("Entere a number between 1-30 for Novemeber!");
                        dayNov = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (dayNovGuessed == false);



            Console.ReadLine();
        }
    }
}
