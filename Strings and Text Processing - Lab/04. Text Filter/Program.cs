namespace _04._Text_Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> banned = Console.ReadLine()
                                  .Split(", ")
                                  .ToList();

            string text = Console.ReadLine();

            foreach (var word in banned)
            {
                while (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
