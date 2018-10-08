using System;

namespace _01.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;

            foreach (char digit in number)
            {
                sum += int.Parse(digit.ToString());
            }

            Console.WriteLine(sum);
        }
    }
}