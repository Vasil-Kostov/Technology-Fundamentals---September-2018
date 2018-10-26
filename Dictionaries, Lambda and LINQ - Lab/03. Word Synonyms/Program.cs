namespace _03._Word_Synonyms
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> wordsWithSynonyms = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!wordsWithSynonyms.ContainsKey(word))
                {
                    wordsWithSynonyms.Add(word, new List<string>());
                }

                wordsWithSynonyms[word].Add(synonym);

            }

            foreach (var kvp in wordsWithSynonyms)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
