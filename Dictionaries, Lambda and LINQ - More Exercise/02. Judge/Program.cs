namespace _02._Judge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> contestsInfo = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> individualStandings = new Dictionary<string, Dictionary<string, int>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "no more time")
            {
                string[] inputArr = inputLine.Split(" -> ");
                string studentName = inputArr[0];
                string contestName = inputArr[1];
                int points = int.Parse(inputArr[2]);

                if (!contestsInfo.ContainsKey(contestName))
                {
                    contestsInfo.Add(contestName, new Dictionary<string, int>());
                }

                if (!contestsInfo[contestName].ContainsKey(studentName))
                {
                    contestsInfo[contestName].Add(studentName, 0);
                }

                if (contestsInfo[contestName][studentName] < points)
                {
                    contestsInfo[contestName][studentName] = points;
                }

                if (!individualStandings.ContainsKey(studentName))
                {
                    individualStandings.Add(studentName, new Dictionary<string, int>());
                }

                if (!individualStandings[studentName].ContainsKey(contestName))
                {
                    individualStandings[studentName].Add(contestName, 0);
                }

                if (individualStandings[studentName][contestName] < points)
                {
                    individualStandings[studentName][contestName] = points;
                }

                inputLine = Console.ReadLine();
            }

            foreach (var contest in contestsInfo)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");

                int counter = 1;

                foreach (var student in contest.Value.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
                {
                    Console.WriteLine($"{counter}. {student.Key} <::> {student.Value}");
                    counter++;
                }
            }

            Console.WriteLine("Individual standings:");

            int count = 1;
            foreach (var student in individualStandings.OrderByDescending(kvp => kvp.Value.Values.Sum()).ThenBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{count}. {student.Key} -> {student.Value.Values.Sum()}");
                count++;
            }
        }
    }
}
