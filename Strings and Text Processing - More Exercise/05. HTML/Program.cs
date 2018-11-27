namespace _05._HTML
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<string> articleInfo = new List<string>();

            articleInfo.Add(Console.ReadLine());
            articleInfo.Add(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end of comments")
            {
                articleInfo.Add(input);

                input = Console.ReadLine();
            }

            Console.WriteLine($"<h1>\n\t{articleInfo[0]}\n</h1>");
            Console.WriteLine($"<article>\n\t{articleInfo[1]}\n</article>");

            for (int i = 2; i < articleInfo.Count; i++)
            {
                Console.WriteLine($"<div>\n\t{articleInfo[i]}\n</div>");
            }
        }
    }
}
