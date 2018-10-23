namespace _04._Mixed_up_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> firstList = Console.ReadLine()
                                     .Split()
                                     .ToList();

            List<string> secondList = Console.ReadLine()
                                     .Split()
                                     .Reverse()
                                     .ToList();

            List<string> ziped = firstList.Zip(secondList, (a, b) => $"{a} {b}").ToList();

            List<int> nums = string.Join(" ", ziped)
                                                .Split()
                                                .Select(int.Parse)
                                                .ToList();
            int[] borders = new int[2];

            if (firstList.Count > secondList.Count)
            {
                firstList.Reverse();
                borders = firstList.Select(int.Parse).Take(2).ToArray();
            }
            else
            {
                secondList.Reverse();
                borders = secondList.Select(int.Parse).Take(2).ToArray();
            }

            List<int> result = nums.Where(n => n > borders.Min() && n < borders.Max()).ToList();

            Console.WriteLine(string.Join(" ", result.OrderBy(n => n)));
        }
    }
}
