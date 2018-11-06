namespace _02._Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> words = Console.ReadLine()
                             .Split()
                             .ToList();

            Random random = new Random();

            for (int i = 0; i < words.Count; i++)
            {
                int firstRndIndex = random.Next(0, words.Count - 1);
                int secondRndIndex = random.Next(0, words.Count - 1);

                string temp = words[firstRndIndex];
                words[firstRndIndex] = words[secondRndIndex];
                words[secondRndIndex] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
