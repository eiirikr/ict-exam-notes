using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Output
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // \t \n \" \\ = \ (scape character)
            string speech = "He said \"something\"";
            string path = "C:\\Users\\Jessa Mae\\OneDrive\\Desktop\\ict-exam-notes\nNew line test";
            Console.WriteLine(path);
            Console.WriteLine(speech);
            // $ +
            // $"Your name is {name}"
            // "Your name is " + name

            path = @"C:\\Users\\Jessa Mae\\OneDrive\\Desktop\\ict-exam-notes" + "\nNew line test";
            Console.WriteLine(path);

            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }

    }
}
