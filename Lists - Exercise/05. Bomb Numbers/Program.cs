namespace _05._Bomb_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            int[] bomb = Console.ReadLine()
                         .Split()
                         .Select(int.Parse)
                         .ToArray();

            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    Detonation(numbers, bombPower, i);
                    i = 0;
                }
            }

            Console.WriteLine(numbers.Sum());

        }

        private static void Detonation(List<int> numbers, int bombPower, int i)
        {
            int startIndex = i - bombPower < 0 ? startIndex = 0 : i - bombPower;

            int endIndex = i + bombPower > numbers.Count - 1 ? numbers.Count - 1 : i + bombPower;
            
            int numbersToRemove = endIndex - startIndex + 1;

            numbers.RemoveRange(startIndex, numbersToRemove);

        }
    }
}
