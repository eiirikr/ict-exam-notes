using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
       /* 
        * Define a variable to hold your name 
        * Define a variable to hold your phone number 
        * Define a variable to hold your age
        * Print variable line-by-line to the screen
        * Extra: define variables usong the var keyword
       */
        static void Main(string[] args)
        {
            const string name = "Jeric";
            string phoneNumber = "09566343793";
            int age = 22;
            
            var varName = "Jeric";
            var varPhoneNumber = "09566343793";
            var varAge = 22;

            Console.WriteLine(name);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(age);

            Console.WriteLine(varName);
            Console.WriteLine(varPhoneNumber);
            Console.WriteLine(varAge);

            Console.ReadLine();
        }
    }
}
