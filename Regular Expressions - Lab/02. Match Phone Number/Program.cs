namespace _02._Match_Phone_Number
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex phoneNumberRegex = new Regex(@"(\+359)( |-)2\2\d{3}\2\d{4}\b");

            MatchCollection validNumbers = phoneNumberRegex.Matches(Console.ReadLine());

            Console.WriteLine(string.Join(", ", validNumbers));
        }
    }
}
