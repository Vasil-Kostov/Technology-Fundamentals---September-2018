namespace _01._Extract_Emails
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex emailRegex = new Regex(@"(\s[a-z]+[\w.-]+\w)@([a-z]+[-a-z]*?([.][a-z]+)+)\b");

            string input = Console.ReadLine();

            Console.WriteLine(string.Join(Environment.NewLine, emailRegex.Matches(input)));
        }
    }
}
