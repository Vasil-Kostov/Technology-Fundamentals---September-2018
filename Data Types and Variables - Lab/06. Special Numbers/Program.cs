using System;

namespace _06.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} -> {IsTheNumberSpecial(i)}");
            }
        }

        private static bool IsTheNumberSpecial(int number)
        {
            int sumOfDigits = 0;

            while (number > 0) 
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }

            if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
            {
                return true;
            }

            return false;

        }
    }
}