namespace _05._Drum_Set
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            List<int> initialDrumsQuality = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToList();

            int[] currentDrumsQuality = initialDrumsQuality.ToArray();
            
            string inputLine = Console.ReadLine();

            while (inputLine != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(inputLine);

                savings = HitTheDrums(currentDrumsQuality, initialDrumsQuality, hitPower, savings);

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", currentDrumsQuality.Where(q => q > 0)));

            Console.WriteLine($"Gabsy has {savings:F2}lv.");

        }

        private static decimal HitTheDrums(int[] currentDrumsQuality, List<int> initialDrumsQuality, int hitPower, decimal savings)
        {
            for (int i = 0; i < currentDrumsQuality.Length; i++)
            {
                if (currentDrumsQuality[i] != 0)
                {
                    currentDrumsQuality[i] -= hitPower;
                }

                if (currentDrumsQuality[i] <= 0)
                {
                    if (savings >= initialDrumsQuality[i] * 3)
                    {
                        savings -= initialDrumsQuality[i] * 3;
                        currentDrumsQuality[i] = initialDrumsQuality[i];

                    }
                    else
                    {
                        currentDrumsQuality[i] = 0;
                    }
                }
            }

            return savings;

        }
    }
}
