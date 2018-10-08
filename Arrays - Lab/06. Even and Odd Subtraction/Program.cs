namespace _06.Even_and_Odd_Subtraction
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int evensSum = input.Split().Select(int.Parse).Where(n => n % 2 == 0).Sum();
            int oddsSum = input.Split().Select(int.Parse).Where(n => n % 2 != 0).Sum();

            Console.WriteLine(evensSum - oddsSum);
        }
    }
}