namespace _02._Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<double> numbers = Console.ReadLine()
                                    .Split()
                                    .Select(double.Parse)
                                    .ToList();

            bool areThereMoreEquals = true;

            while (areThereMoreEquals)
            {
                areThereMoreEquals = SumAdjacentEquals(numbers);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static bool SumAdjacentEquals(List<double> numbers)
        {
            bool anySumed = false;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] *= 2;
                    numbers.RemoveAt(i + 1);
                    anySumed = true;
                }
            }

            return anySumed;

        }
    }
}
