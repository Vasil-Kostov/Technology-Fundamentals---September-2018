namespace _07._Append_Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> numbersAsStrings = Console.ReadLine()
                                            .Split('|')
                                            .Reverse()
                                            .ToList();

            List<int> numbers = new List<int>();

            foreach (var str in numbersAsStrings)
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList()
                                    );
            }

            Console.WriteLine(string.Join(" ", numbers));
                               
        }
    }
}
