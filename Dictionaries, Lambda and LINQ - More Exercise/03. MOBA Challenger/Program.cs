namespace _03._MOBA_Challenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> statistics = new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "Season end")
            {
                if (inputLine.Contains(" -> "))
                {
                    string[] inputArr = inputLine.Split(" -> ");
                    string playerName = inputArr[0];
                    string position = inputArr[1];
                    int skill = int.Parse(inputArr[2]);

                    if (!statistics.ContainsKey(playerName))
                    {
                        statistics.Add(playerName, new Dictionary<string, int>());
                    }

                    if (!statistics[playerName].ContainsKey(position))
                    {
                        statistics[playerName].Add(position, 0);
                    }

                    if (statistics[playerName][position] < skill)
                    {
                        statistics[playerName][position] = skill;
                    }

                }
                else if (inputLine.Contains(" vs "))
                {
                    string[] inputArr = inputLine.Split(" vs ");
                    string firstPlayer = inputArr[0];
                    string secondPlayer = inputArr[1];

                    if (statistics.ContainsKey(firstPlayer) && statistics.ContainsKey(secondPlayer))
                    {
                        foreach (var position in statistics[firstPlayer].Keys)
                        {
                            if (statistics[secondPlayer].ContainsKey(position))
                            {
                                if (statistics[firstPlayer].Values.Sum() > statistics[secondPlayer].Values.Sum())
                                {
                                    statistics.Remove(secondPlayer);
                                }
                                else if (statistics[secondPlayer].Values.Sum() > statistics[firstPlayer].Values.Sum())
                                {
                                    statistics.Remove(firstPlayer);
                                }
                                break;
                            }
                        }
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (var player in statistics.OrderByDescending(kvp => kvp.Value.Values.Sum()).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var kvp in player.Value.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
                {
                    Console.WriteLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            
            }

        }
    }
}
