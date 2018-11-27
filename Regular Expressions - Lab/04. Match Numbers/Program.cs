namespace _04._Match_Numbers
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex numbersRegex = new Regex(@"^(-\d+|\d+)?(\.?\d+|)$");

            string[] strings = Console.ReadLine()
                               .Split();

            string[] numbers = strings.Where(s => numbersRegex.IsMatch(s)).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
