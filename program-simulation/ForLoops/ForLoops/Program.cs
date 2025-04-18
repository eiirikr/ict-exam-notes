using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a message: ");
            string message = Console.ReadLine();

            if (number <= 0)
            {
                Console.WriteLine("Sorry, please enter a value above 0.");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(message);
                }
            }

            Console.ReadLine();
        }
    }
}
