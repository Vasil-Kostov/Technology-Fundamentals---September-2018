namespace _03.Recursive_Fibonacci
{
    using System;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int wantedFibNumb = int.Parse(Console.ReadLine());

            Console.WriteLine(GetNthFibonacciNumber(wantedFibNumb));
        }

        static BigInteger GetNthFibonacciNumber(int wantedFibNumb)
        {
            if (wantedFibNumb == 1 || wantedFibNumb == 2)
            {
                return 1;
            }
            if (wantedFibNumb <= 0)
            {
                return 0;
            }

            BigInteger[] fibSequence = new BigInteger[wantedFibNumb];

            fibSequence[0] = 1;
            fibSequence[1] = 1;

            for (int i = 2; i < wantedFibNumb; i++)
            {
                fibSequence[i] = fibSequence[i - 1] + fibSequence[i - 2]; 
            }

            return fibSequence[wantedFibNumb - 1];

        }
    }
}