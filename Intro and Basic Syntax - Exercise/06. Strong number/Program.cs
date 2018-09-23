using System;

namespace _06.Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            long factorialsSum = 0;

            foreach (char digit in number)
            {
                int factorial = GetDigitsFactorial(digit);
                factorialsSum += factorial;
            }

            Console.WriteLine(factorialsSum == int.Parse(number) ? "yes" : "no");
           
        }

        static int GetDigitsFactorial(char digit)
        {
            int num = int.Parse(digit.ToString());

            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}