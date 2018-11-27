namespace _06._Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex lettersRegex = new Regex(@"([^\d\+\-\*/\.])");
            Regex numbersRegex = new Regex(@"((\+|\-)?(\d+(\.\d+)?))");
            Regex multAndDivRegex = new Regex(@"(/|\*)");

            List<string> demons = Console.ReadLine()
                                  .Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                  .ToList();

            foreach (var demon in demons.OrderBy(n => n))
            {
                string demonLetters = "";
                
                foreach (var letter in lettersRegex.Matches(demon))
                {
                    demonLetters += letter.ToString();
                }

                List<Match> numbers = numbersRegex.Matches(demon).ToList();

                decimal damage = 0;

                if (numbers.Count > 0)
                {
                    foreach (var num in numbers)
                    {
                        damage += decimal.Parse(num.ToString());
                    }

                    MatchCollection multiAndDiv = multAndDivRegex.Matches(demon);

                    if (multiAndDiv.Count() > 0)
                    {
                        foreach (var symbol in multiAndDiv)
                        {
                            if (symbol.ToString() == "*")
                            {
                                damage *= 2;
                            }
                            else if (symbol.ToString() == "/")
                            {
                                damage /= 2;
                            }
                        }
                    }
                }

                int health = 0;

                foreach (var symbol in demonLetters)
                {
                    health += symbol;
                }

                Console.WriteLine($"{demon} - {health} health, {damage:F2} damage");
            }
        }
    }
}
