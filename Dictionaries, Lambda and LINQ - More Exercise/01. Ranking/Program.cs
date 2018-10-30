namespace _01._Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, string> contestAndPass = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> usersResults = new Dictionary<string, Dictionary<string, int>>();

            ReadTheContestsWithTheirPasswords(contestAndPass);

            string inputLine = Console.ReadLine();

            while (inputLine != "end of submissions")
            {
                string[] inputArray = inputLine.Split("=>");
                string contest = inputArray[0];
                string pass = inputArray[1];
                string username = inputArray[2];
                int points = int.Parse(inputArray[3]);

                if (contestAndPass.ContainsKey(contest) && contestAndPass[contest] == pass)
                {
                    if (!usersResults.ContainsKey(username))
                    {
                        usersResults.Add(username, new Dictionary<string, int>());
                    }

                    if (!usersResults[username].ContainsKey(contest))
                    {
                        usersResults[username].Add(contest, 0);
                    }

                    if (usersResults[username][contest] < points)
                    {
                        usersResults[username][contest] = points;
                    }
                }


                inputLine = Console.ReadLine();
            }

            PrintBestCandidate(usersResults);

            PrintAllStudents(usersResults);

        }

        private static void PrintAllStudents(Dictionary<string, Dictionary<string, int>> usersResults)
        {
            Console.WriteLine("Ranking: ");

            foreach (var student in usersResults.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{student.Key}");

                foreach (var kvp in student.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine($"#  {kvp.Key} -> {kvp.Value}");
                }
            }
        }

        private static void PrintBestCandidate(Dictionary<string, Dictionary<string, int>> usersResults)
        {
            foreach (var user in usersResults.OrderByDescending(kvp => kvp.Value.Values.Sum()))
            {
                Console.WriteLine($"Best candidate is {user.Key} with total {user.Value.Values.Sum()} points.");
                return;
            }
        }

        private static void ReadTheContestsWithTheirPasswords(Dictionary<string, string> contestAndPass)
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "end of contests")
            {
                if (inputLine.Contains(':'))
                {
                    string[] inputArr = inputLine.Split(':');
                    string contestName = inputArr[0];
                    string contestPass = inputArr[1];

                    if (!contestAndPass.ContainsKey(contestName))
                    {
                        contestAndPass.Add(contestName, contestPass);
                    }
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
