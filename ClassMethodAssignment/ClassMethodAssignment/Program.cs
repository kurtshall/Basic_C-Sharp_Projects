
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassMethodAssignment;


public class Program
{
    static void Main(string[] args)
    {
        //calling and setting the class
        UserMath math = new UserMath();
        //taking user input
        Console.WriteLine("Please enter a number to do some math on: ");
        int userNum = Convert.ToInt32(Console.ReadLine());

        //calling the method in the class
        int equal = math.Addition(userNum);
        Console.WriteLine(userNum + " + 5 = " + equal);

        //calling the method in the class
        int equal2 = math.Subtraction(userNum);
        Console.WriteLine(userNum + " - 5 = " + equal2);

        //calling the method in the class
        int equal3 = math.Multi(userNum);
        Console.WriteLine(userNum + " * 5 = " + equal3);


        Console.ReadLine();
    }
}

