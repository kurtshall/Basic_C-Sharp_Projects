using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Program
{
    static void Main()
    {
        //Part one
        string[] colors = { "green-", "red-", "blue-", "yellow-", "orange-", };
        

        Console.WriteLine("Input a color: ");
        string color = (Console.ReadLine());

        for (int i = 0; i < colors.Length; i++)
        {
            string hold = colors[i] + color;
            colors[i] = hold;
        }

        for (int i = 0; i < colors.Length; i++)
        {
            Console.WriteLine(colors[i]);
        }

        //part two
        List<int> num = new List<int>();
        num.Add(1);
        num.Add(3);

        //to make i infinite loop, i had it set as for (int j = 0; j > -1; j++ )
        for (int j = 0; j < 10; j++ )
        {
            num.Add(j);
            Console.WriteLine(num[j]);
        }
        

        //part three
        

        for (int j = 0; j < 5; j++)
        {
            
            Console.WriteLine(num[j]);
        }

        for (int j = 0; j <= 5; j++)
        {
            
            Console.WriteLine(num[j]);
        }
        
        //part four
        string[] names = { "Steve", "John", "Sarah", "Mike" };
        Console.WriteLine("Type in a name to search: ");
        string namecheck = (Console.ReadLine());


        
        for (int k = 0; k < names.Length; k++)
        {
            //if statment to check if the name is in the system
            if (namecheck == names[k])
            {
                Console.WriteLine("That name was in the system at index: " + k);
                break;
            }
            //if it reaches the end of the length of the list and no name is found the same it will print this
            else if (k == names.Length - 1)
            {
                Console.WriteLine("That name was not in the system!");
            }
        }


        //part five
        string[] names2 = { "Steve", "John", "Sarah", "Mike", "John", "Sarah", "Joe" };
        List<int> sameName = new List<int>();
        Console.WriteLine("Type in a name to search how many there are: ");
        string namecheck2 = (Console.ReadLine());
        





        for (int i = 0; i < names2.Length; i++)
        {
            

            if (names2[i] == namecheck2)
            {
                Console.WriteLine("That name was in the system at index: " + i);
                //check system to see if it shows up
                sameName.Add(1);
            }

        }
        //checks if any names showed up
        if (sameName.Count == 0)
            {
                Console.WriteLine("That name was not in the system!");
            }
        
        //Console.WriteLine("Done part 5");

        








        //part 6
        string[] names3 = { "Steve", "John", "Sarah", "Mike", "John", "Sarah", "Joe" };
        List<int> sameName2 = new List<int>();
        Console.WriteLine("Type in a name to search how many there are: ");
        string namecheck3 = (Console.ReadLine());


        foreach (string pass in names3)
        {
            if (pass == namecheck3)
            {
                Console.WriteLine("The name " + namecheck3+ " was in the system!");
                //setting an if statment to see if the name was already used
                if (sameName2.Count > 0)
                {
                    Console.WriteLine("The name " + namecheck3 + " was already in the system!");
                }
                //adding to the value after checking if the name was already used
                sameName2.Add(1);
            }


        }

        //Console.WriteLine(sameName2.Count);

        if (sameName2.Count == 0)
        {
            Console.WriteLine("The name " + namecheck3 + " was not in the system!");
        }
        Console.ReadLine();
    }
}

