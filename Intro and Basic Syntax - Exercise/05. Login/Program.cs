using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> user = Console.ReadLine().ToCharArray().ToList();

            string userName = string.Join("", user);
            user.Reverse();
            string password = string.Join("", user);
            
            for (int i = 0; i < 4; i++)
            {
                if (Console.ReadLine() == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else if (i == 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}