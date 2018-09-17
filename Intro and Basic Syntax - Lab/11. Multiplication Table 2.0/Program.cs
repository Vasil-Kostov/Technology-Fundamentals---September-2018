using System;

namespace _11.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());

            if (start <= 10)
            {
                for (int times = start; times <= 10; times++)
                {
                    Console.WriteLine($"{number} X {times} = {number * times}");
                }

            }
            else
            {
                Console.WriteLine($"{number} X {start} = {number * start}");

            }
        }
    }
}