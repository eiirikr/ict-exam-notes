using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter a message: ");
            string message = Console.ReadLine();

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int i = 0;

            while (i < number)
            {
                Console.WriteLine(message);
                i++;
            }*/

            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int correctAnswer = num2 * num2;
            int userAnswer = 0;

            Console.WriteLine("What is the value of " + num1 + " x " + num2 + " ?");

            /*while (userAnswer != correctAnswer)
            {
                Console.Write("Enter your answer: ");
                userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer != correctAnswer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            }*/

            do
            {
                Console.Write("Enter your answer: ");
                userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer != correctAnswer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();
                }
            } while (userAnswer != correctAnswer);

            Console.WriteLine("Well done!");

            Console.ReadLine();
        }
    }
}
