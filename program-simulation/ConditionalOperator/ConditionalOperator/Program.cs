using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int age = Convert.ToInt32(Console.ReadLine());

            string result = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
