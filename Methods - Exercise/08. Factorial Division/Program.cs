namespace _08._Factorial_Division
{
    using System;

    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            PrintFactorianDivision(firstNum, secondNum);

        }

        private static void PrintFactorianDivision(int firstNum, int secondNum)
        {
            long firstNumFactorial = GetNumbersFactorial(firstNum);
            long secondNumFactorial = GetNumbersFactorial(secondNum);

            double divided = firstNumFactorial / (double)secondNumFactorial;

            Console.WriteLine($"{divided:F2}");
        }

        private static long GetNumbersFactorial(int num)
        {
            long factorial = 1;

            for (int i = 2; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
