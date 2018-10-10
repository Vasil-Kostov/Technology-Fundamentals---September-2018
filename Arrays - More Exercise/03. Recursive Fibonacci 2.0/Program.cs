namespace _03.Recursive_Fibonacci_2._0
{
    using System;

    class Program
    {
        static void Main()
        {
            int fibNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(fibNumber));
        }

        static long Fib(int n)
        {
            if (n == 2 || n == 1)
            {
                return 1;
            }
            if (n <= 0)
            {
                return 0;
            }

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
