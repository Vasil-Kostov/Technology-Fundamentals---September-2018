using System;

namespace _03.Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine(grade >= 3.00 ? "Passed!" : "Failed!");
        }
    }
}