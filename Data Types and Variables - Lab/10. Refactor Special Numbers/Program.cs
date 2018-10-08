using System;

namespace _10.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int number = 1; number <= n; number++)
            {
                int currentNumber = number;
                int digitsSum = 0;

                while (currentNumber > 0)
                {
                    digitsSum += currentNumber % 10;
                    currentNumber /= 10;
                }

                bool isSpecial = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);

                Console.WriteLine($"{number} -> {isSpecial}");
            }

        }
    }
}