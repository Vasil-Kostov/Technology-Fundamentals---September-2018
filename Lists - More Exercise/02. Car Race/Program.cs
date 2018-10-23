namespace _02._Car_Race
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            double firstPlayerScore = 0;
            double secondPlayerScore = 0;

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    firstPlayerScore *= 0.8;
                }
                else if(numbers[i] > 0)
                {
                    firstPlayerScore += numbers[i];
                }

                if (numbers[numbers.Length - 1 -i] == 0)
                {
                    secondPlayerScore *= 0.8;
                }
                else if (numbers[numbers.Length - 1 - i] > 0)
                {
                    secondPlayerScore += numbers[numbers.Length - 1 - i];
                }

            }

            if (firstPlayerScore < secondPlayerScore)
            {
                Console.WriteLine($"The winner is left with total time: {firstPlayerScore}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondPlayerScore}");
            }
        }
    }
}
