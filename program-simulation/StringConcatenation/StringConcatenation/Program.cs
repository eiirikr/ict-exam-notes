﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatenation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jeric";
            int age = 22;

            Console.WriteLine("Your name is " + name + " and your age is " + age);
            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
            Console.WriteLine($"Your name is {name} and your age is {age}");

            string test = string.Concat("Your name is ", name, " and your age is ", age);
            Console.WriteLine(test);


            Console.ReadLine();
        }
    }
}
