namespace _02._Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().ToLower().Split();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 0);
                }

                words[word]++;
            }

            List<string> result = new List<string>();

            foreach (var word in words.Where(w => w.Value % 2 != 0))
            {
                result.Add(word.Key);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
