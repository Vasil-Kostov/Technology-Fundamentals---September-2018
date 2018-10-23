namespace _07._Merging_Lists
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
                                  .ToList();

            List<string> zip = firstList.Zip(secondList, (a, b) => $"{a} {b}").ToList();

            if (firstList.Count > secondList.Count)
            {
                zip.AddRange(firstList.Skip(secondList.Count));
            }
            else if (secondList.Count > firstList.Count)
            {
                zip.AddRange(secondList.Skip(firstList.Count));
            }

            Console.WriteLine(string.Join(" ", zip));
        }
    }
}
