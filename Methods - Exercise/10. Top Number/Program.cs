namespace _10._Top_Number
{
    using System;

    class Program
    {
        static void Main()
        {
            int border = int.Parse(Console.ReadLine());

            for (int i = 1; i <= border; i++)
            {
                if (IsTopInteger(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopInteger(int number)
        {
            bool sumDivisibleByEight = IsTheSumOfDigitsDivisibleByEight(number);
            bool containsAnOddDigit = HasTheNumberContainsAnOddDigit(number);

            if (sumDivisibleByEight && containsAnOddDigit)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool HasTheNumberContainsAnOddDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                number /= 10;
            }

            return false;

        }

        private static bool IsTheSumOfDigitsDivisibleByEight(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
