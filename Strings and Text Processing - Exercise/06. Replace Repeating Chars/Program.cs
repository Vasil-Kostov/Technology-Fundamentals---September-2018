namespace _06._Replace_Repeating_Chars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine()
                           .ToCharArray();

            List<char> result = new List<char>();

            result.Add(input[0]);
                       
            foreach (var symbol in input)
            {
                if (symbol != result.Last())
                {
                    result.Add(symbol);
                }
            }

            Console.WriteLine(string.Join(string.Empty, result));
                           
        }
    }
}
