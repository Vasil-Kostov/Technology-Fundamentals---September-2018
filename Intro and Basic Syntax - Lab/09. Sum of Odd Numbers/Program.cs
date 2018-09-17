using System;

namespace _09.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int currentNum = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(currentNum);
                sum += currentNum;
                currentNum += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}