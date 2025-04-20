using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your message: ");
            string message = Console.ReadLine();

            for (int i = 0; i < message.Length; i++) // 0-5
            {
                Console.Write(message[i]);
            }

            Console.WriteLine();

            for (int i = message.Length - 1; i >= 0; i--) // 5-0
            {
                Console.Write(message[i]);
            }

            Console.ReadLine();
        }
    }
}
