﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAndVarAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {

            const string newName = "This string is a const variable!";
            var anotherName = "This is a string variable using var";
        }

        public class sampleChain
        {
            public sampleChain()
            {

            }
            public sampleChain(int age) : this()
            {
                this.Age = age;
            }
            public sampleChain(int age, string name) : this(age)
            {
                this.Name = name;
            }
            public int Age { get; }
            public string Name { get; }
        }

        
    }
}
