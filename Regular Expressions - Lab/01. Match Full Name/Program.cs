namespace _01._Match_Full_Name
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex regex = new Regex(@"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b");

            string names = Console.ReadLine();

            MatchCollection validNames = regex.Matches(names);

            Console.WriteLine(string.Join(" ", validNames));
        }
    }
}
