using System;

namespace _05.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            long hours = 24 * days;
            long minutes = 60 * hours;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");

        }
    }
}