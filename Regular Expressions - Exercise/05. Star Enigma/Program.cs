namespace _05._Star_Enigma
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex decriptionKeyRegex = new Regex(@"[SsTtAaRr]");
            Regex pattern = new Regex(@"@([A-Z][a-z]+)[^@\-!:>]*:(\d+)[^@\-!:>]*!([A|D])![^@\-!:>]*->(\d+)");

            List<string> attckedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            int numberOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfMessages; i++)
            {
                string input = Console.ReadLine();

                int decryptionKey = decriptionKeyRegex.Matches(input).Count;

                string decrypted = string.Empty;

                for (int j = 0; j < input.Length; j++)
                {
                    decrypted += (char)(input[j] - decryptionKey);
                }

                if (pattern.IsMatch(decrypted))
                {
                    string planetName = pattern.Match(decrypted).Groups[1].ToString();
                    char attackType = char.Parse(pattern.Match(decrypted).Groups[3].ToString());

                    if (attackType == 'A')
                    {
                        attckedPlanets.Add(planetName);
                    }
                    else if (attackType == 'D')
                    {
                        destroyedPlanets.Add(planetName);
                    }
                }

            }

            Console.WriteLine($"Attacked planets: {attckedPlanets.Count}");
            if (attckedPlanets.Count > 0)
            {
                foreach (var planet in attckedPlanets.OrderBy(pn => pn))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var planet in destroyedPlanets.OrderBy(pn => pn))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
