namespace _01._Remove_Negatives_and_Reverse
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
                                .Where(n => n >= 0)
                                .Reverse()
                                .ToList();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");

            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers));

            }

        }
    }
}
