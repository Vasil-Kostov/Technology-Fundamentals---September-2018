namespace _05._Digits__Letters_and_Other
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex digitRegex = new Regex(@"\d");
            Regex charRegex = new Regex(@"[A-Za-z]");
            Regex anyOtherRegex = new Regex(@"[\W|_]");

            string input = Console.ReadLine();

            string digits = string.Join("", digitRegex.Matches(input));
            string chars = string.Join("", charRegex.Matches(input));
            string others = string.Join("", anyOtherRegex.Matches(input));

            Console.WriteLine(digits);
            Console.WriteLine(chars);
            Console.WriteLine(others);
                        
        }
    }
}
