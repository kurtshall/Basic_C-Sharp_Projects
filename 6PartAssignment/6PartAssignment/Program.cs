using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        List<string> colors = new List<string>();
        colors.Add("green");
        colors.Add("red");
        colors.Add("blue");
        colors.Add("yellow");
        colors.Add("orange");

        Console.WriteLine("Input a color: ");
        colors.Add(Console.ReadLine());

        for (int i = 1; i < colors.Count; i++)
        {
            Console.WriteLine(colors[i]);
        }
        

        List<int> num = new List<int>();
        num.Add(1);
        num.Add(3);

        for (int j = 0; j < 10; j++ )
        {
            num.Add(j);
            Console.WriteLine(num[j]);
        }
        


        List<int> num2 = new List<int>();
        num.Add(4);
        num.Add(5);

        for (int j = 0; j <= 10; j++)
        {
            num.Add(j);
            Console.WriteLine(num[j+3]);
        }
        

        string[] names = { "Steve", "John", "Sarah", "Mike" };
        Console.WriteLine("Type in a name to search: ");
        string namecheck = (Console.ReadLine());


        
        for (int k = 0; k < names.Length; k++)
        {
            if (namecheck == names[k])
            {
                Console.WriteLine("That name was in the system!");
            }

            else if (k == names.Length - 1)
            {
                Console.WriteLine("That name was not in the system!");
            }
        }


        string[] names2 = { "Steve", "John", "Sarah", "Mike", "John", "Sarah", "Joe" };
        List<int> sameName = new List<int>();
        Console.WriteLine("Type in a name to search how many there are: ");
        string namecheck2 = (Console.ReadLine());


        foreach (string pass in names2)
        {
            if (pass == namecheck2)
            {
                Console.WriteLine("That name was in the system!");
                sameName.Add(1);
            }
                    
            
        }

        Console.WriteLine(sameName.Count);

        if (sameName.Count == 0)
        {
            Console.WriteLine("That name was not in the system!");
        }



        Console.ReadLine();
    }
}

