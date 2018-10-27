namespace _02._Baking_Rush
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> events = Console.ReadLine()
                                  .Split('|')
                                  .ToList();

            int energy = 100;
            int coins = 100;

            foreach (var eventOrIgredient in events)
            {
                string[] tokens = eventOrIgredient.Split('-').ToArray();

                switch (tokens[0])
                {
                    case "rest":
                        int energyGained = int.Parse(tokens[1]);
                        if (energy == 100)
                        {
                            Console.WriteLine("You gained 0 energy.");
                        }
                        else if (energy + energyGained > 100)
                        {
                            Console.WriteLine($"You gained {100 - energy} energy.");
                            energy = 100;
                        }
                        else
                        {
                            Console.WriteLine($"You gained {energyGained} energy.");
                            energy += energyGained;
                        }

                        Console.WriteLine($"Current energy: {energy}.");

                        break;
                        
                    case "order":
                        int coinsEarned = int.Parse(tokens[1]);

                        if (energy >= 30)
                        {
                            Console.WriteLine($"You earned {coinsEarned} coins.");
                            coins += coinsEarned;
                            energy -= 30;
                        }
                        else
                        {
                            Console.WriteLine($"You had to rest!");
                            energy += 50;
                        }
                        break;

                    default:
                        string ingredient = tokens[0];
                        int cost = int.Parse(tokens[1]);

                        if (coins > cost)
                        {
                            Console.WriteLine($"You bought {ingredient}.");
                            coins -= cost;
                        }
                        else
                        {
                            Console.WriteLine($"Closed! Cannot afford {ingredient}.");
                            return;
                        }

                        break;
                }

            }

            Console.WriteLine($"Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: { energy}");
        }
    }
}
