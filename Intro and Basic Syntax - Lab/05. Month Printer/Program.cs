using System;

namespace _05.Month_Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 12)
            {
                Console.WriteLine("Error!");
            }
            else
            {
                DateTime time = new DateTime(2018, number, 1);
                Console.WriteLine(time.ToString("MMMM"));
            }
        }
    }
}