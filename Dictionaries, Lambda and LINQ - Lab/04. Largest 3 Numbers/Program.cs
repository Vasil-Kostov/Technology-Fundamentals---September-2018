namespace _04._Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToList();

            Console.WriteLine(string.Join(" ", nums.OrderByDescending(n => n).Take(3)));
        }
    }
}
