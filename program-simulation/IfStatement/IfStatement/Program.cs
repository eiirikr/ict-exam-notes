using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and you're " + age + " years old.");

            if (age <= 12)
            {
                Console.WriteLine("You're too young.");
            }
            else if (age > 12 && age < 20)
            {
                Console.WriteLine("You're a teen.");
            } 
            else
            {
                Console.WriteLine("You're an adult.");
            }*/

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int correctAnswer = num1 * num2;

            Console.Write("Value of " + num1 + " x " + num2 + ": ");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == correctAnswer)
            {
                Console.WriteLine("Well Done!");
            }
            else
            {
                Console.WriteLine("Close but it was wrong");
            }

            Console.ReadLine();
        }
    }
}