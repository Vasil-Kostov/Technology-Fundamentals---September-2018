namespace _01._Valid_Usernames
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex pattern = new Regex(@"^(\w+(-\w*)*)$");

            string[] userNames = Console.ReadLine().Split(", ");

            List<string> validUserNames = new List<string>();

            foreach (var name in userNames)
            {
                if (pattern.IsMatch(name) && (name.Length >= 3 && name.Length <= 16))
                {
                    validUserNames.Add(name);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUserNames));
        }
    }
}
