namespace _01._Count_Chars_in_a_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string text = string.Join(string.Empty, Console.ReadLine().Split());

            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();

            foreach (var symbol in text)
            {
                if (!charOccurrences.ContainsKey(symbol))
                {
                    charOccurrences.Add(symbol, 0);
                }

                charOccurrences[symbol]++;

            }

            foreach (var kvp in charOccurrences)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
                          
        }
    }
}
