﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(50);
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains('C'));

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('C'))
                {
                    contains = true;
                }
            }

            Console.WriteLine(contains);

            Console.ReadLine();
        }
    }
}
