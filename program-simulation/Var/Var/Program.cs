using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = -22;
            Console.WriteLine(age);

            var bigNumber = 9000000000L;
            Console.WriteLine(bigNumber);

            var negative = -55.2D;
            Console.WriteLine(negative);

            var precision = 5.0000001F;
            Console.WriteLine(precision);

            var money = 34.99M;
            Console.WriteLine(money);

            var name = "Jeric";
            Console.WriteLine(name);

            var letter = 'j';
            Console.WriteLine(letter);

            Console.ReadLine();
        }
    }
}
