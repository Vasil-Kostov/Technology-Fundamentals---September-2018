namespace _01._Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            string[] wordsWithDescription = Console.ReadLine()
                                            .Split(" | ");

            string[] onlyWords = Console.ReadLine()
                                 .Split(" | ");

            foreach (var wordWithDesc in wordsWithDescription)
            {
                string[] arr = wordWithDesc.Split(": ");
                string word = arr[0];
                string description = arr[1];

                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                }

                dictionary[word].Add(description);
            }

            string command = Console.ReadLine();

            if (command == "End")
            {
                foreach (var word in onlyWords)
                {
                    if (dictionary.ContainsKey(word))
                    {
                        Console.WriteLine(word);

                        foreach (var desc in dictionary[word].OrderByDescending(d => d.Length))
                        {
                            Console.WriteLine($" -{desc}");
                        }
                    }
                }
            }
            else
            {
                List<string> keys = dictionary.Keys.OrderBy(k => k).ToList();

                Console.WriteLine(string.Join(" ", keys));
            }
        }
    }
}
