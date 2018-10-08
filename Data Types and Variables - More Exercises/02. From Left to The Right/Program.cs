namespace _02.From_Left_to_The_Right
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

                if (numbers[0] > numbers[1])
                {
                    Console.WriteLine(NumberDigitsSum(numbers[0]));
                }
                else
                {
                    Console.WriteLine(NumberDigitsSum(numbers[1]));
                }
            }
        }

        static long NumberDigitsSum(long number)
        {
            long sum = 0;

            number = Math.Abs(number);

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;
        }
    }
}