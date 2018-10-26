namespace _05._Word_Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> result = Console.ReadLine()
                                  .Split()
                                  .Where(w => w.Length % 2 == 0)
                                  .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
