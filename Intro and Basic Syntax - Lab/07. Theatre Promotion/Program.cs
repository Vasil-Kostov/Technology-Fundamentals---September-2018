using System;

namespace _07.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (typeOfDay == "Weekday")
            {
                Console.WriteLine((age >= 0 && age <= 18) || (age > 64 && age <= 122) ? "12$" : "18$");
            }
            else if (typeOfDay == "Weekend")
            {
                Console.WriteLine((age >= 0 && age <= 18) || (age > 64 && age <= 122) ? "15$" : "20$");
            }
            else
            {
                if (age >= 0 && age <= 18)
                {
                    Console.WriteLine("5$");
                }
                else
                {
                    Console.WriteLine((age > 18 && age <= 64) ? "12$" : "10$");
                }
            }
        }
    }
}