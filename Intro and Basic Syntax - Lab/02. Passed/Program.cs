using System;

namespace _02.Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            string toPrint = grade >= 3.00 ? "Passed!" : string.Empty ;

            Console.WriteLine(toPrint);
        }
    }
}