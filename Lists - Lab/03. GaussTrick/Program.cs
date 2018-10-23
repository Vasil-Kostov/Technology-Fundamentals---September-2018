namespace _03._GaussTrick
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

            List<int> sumed = SumTheList(numbers);

            Console.WriteLine(string.Join(" ", sumed));
        }

        private static List<int> SumTheList(List<int> numbers)
        {
            List<int> sumed = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                sumed.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
            }

            if (numbers.Count % 2 != 0)
            {
                sumed.Add(numbers[numbers.Count / 2]);
            }

            return sumed;
        }
    }
}
