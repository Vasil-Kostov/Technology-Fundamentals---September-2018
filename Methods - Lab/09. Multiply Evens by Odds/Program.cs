namespace _09._Multiply_Evens_by_Odds
{
    using System;

    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOddDigits(Math.Abs(number));

            Console.WriteLine(result);

        }

        static int GetMultipleOfEvenAndOddDigits(int number)
        {
            int[] evenAndOddDigitsSums = GetSumOfEvenAndOddDigits(number);

            return evenAndOddDigitsSums[0] * evenAndOddDigitsSums[1];

        }

        static int[] GetSumOfEvenAndOddDigits(int number)
        {
            int[] separatedDigits = new int[2];

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0) 
                {
                    separatedDigits[0] += digit;
                }
                else
                {
                    separatedDigits[1] += digit;
                }

                number /= 10;

            }

            return separatedDigits;

        }
    }
}
