namespace _01._Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine()
                               .Split()
                               .Select(double.Parse)
                               .ToArray();

            SortedDictionary<double, int> result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result.Add(number, 0);
                }

                result[number]++;

            }

            foreach (var num in result)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
