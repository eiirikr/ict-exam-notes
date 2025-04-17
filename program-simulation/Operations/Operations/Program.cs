using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 22;

            age += 10;
            Console.WriteLine(age);

            double height = 170;
            height /= 100;
            Console.WriteLine(height);

            string name = "Jeric";
            name += " is programmer!";
            Console.WriteLine(name);

            int count = 25;
            string date = "25";
            Console.WriteLine(count + date);

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++);
            Console.WriteLine(++i);
            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
