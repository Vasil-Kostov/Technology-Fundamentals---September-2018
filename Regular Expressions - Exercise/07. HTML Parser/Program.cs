namespace _07._HTML_Parser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main() // 80/100
        {
            Regex titleRegex = new Regex(@"<title>(.+)</title>");
            Regex bodyRegex = new Regex(@"<body>(.*?)</body>");

            string input = Console.ReadLine();

            string title = titleRegex.Match(input).Groups[1].ToString();

            string body = bodyRegex.Match(input).Groups[1].ToString();

            string contentWithSpaceTags = string.Join(" ", Regex.Split(body, @"<.*?>"));

            string contentWithMultipleWhiteSpaces = Regex.Replace(contentWithSpaceTags, @"\\n", " ");

            List<string> content = contentWithMultipleWhiteSpaces
                                   .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                   .ToList();

            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Content: {string.Join(" ", content)}");
        }
    }
}
