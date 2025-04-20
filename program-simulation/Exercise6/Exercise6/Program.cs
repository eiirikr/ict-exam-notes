using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter confirm password: ");
            string confirmPassword = Console.ReadLine();
            
            if (!password.Equals(string.Empty))
            {
                if (!confirmPassword.Equals(string.Empty))
                {
                    if (password.Length >= 6)
                    {
                        if (password.Equals(confirmPassword))
                        {
                            Console.WriteLine("Passwords match");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Password should 6 or more characters long.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a confirm password.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a password.");
            }

            Console.ReadLine();
        }
    }
}
