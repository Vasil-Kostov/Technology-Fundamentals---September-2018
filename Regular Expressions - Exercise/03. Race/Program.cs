namespace _03._Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex lettersRegex = new Regex(@"[A-Za-z]");
            Regex digitsRegex = new Regex(@"[0-9]");
            
            Dictionary<string, int> runners = new Dictionary<string, int>();

            foreach (var name in Console.ReadLine().Split(", "))
            {
                runners.Add(name, 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = "";

                foreach (var letter in lettersRegex.Matches(input))
                {
                    name += letter;
                }

                if (runners.ContainsKey(name))
                {
                    int distance = 0;

                    foreach (var digit in digitsRegex.Matches(input))
                    {
                        distance += int.Parse(digit.ToString());
                    }

                    runners[name] += distance;
                }

                input = Console.ReadLine();
            }


            Dictionary<string, int> winers = runners.OrderByDescending(kvp => kvp.Value)
                                             .Take(3)
                                             .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            Console.WriteLine($"1st place: {winers.Keys.First()}");
            winers.Remove(winers.Keys.First());
            Console.WriteLine($"2nd place: {winers.Keys.First()}");
            winers.Remove(winers.Keys.First());
            Console.WriteLine($"3rd place: {winers.Keys.First()}");

        }
    }
}
