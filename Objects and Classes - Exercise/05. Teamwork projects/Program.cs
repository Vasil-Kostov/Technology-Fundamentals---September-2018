namespace _05._Teamwork_projects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Team> teams = new List<Team>();

            int teamsToCreate = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamsToCreate; i++)
            {
                string[] input = Console.ReadLine().Split("-");

                if (!teams.Any(t => t.TeamName == input[1]))
                {
                    if (!teams.Any(t => t.CreatorName == input[0]))
                    {
                        teams.Add(new Team(input));
                        Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {input[1]} was already created!");
                }
            }

            string[] userAndTeam = Console.ReadLine().Split("->");

            while (userAndTeam[0] != "end of assignment")
            {
                string teamName = userAndTeam[1];
                string user = userAndTeam[0];

                if (!teams.Any(t => t.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else
                {
                    if (teams.Any(t => t.CreatorName == user) || teams.Any(t => t.Members.Contains(user)))
                    {
                        Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    }
                    else
                    {
                        teams.Find(t => t.TeamName == teamName).Members.Add(user);
                    }
                }

                userAndTeam = Console.ReadLine().Split("->");
            }

            foreach (var team in teams.Where(t => t.Members.Count > 0)
                                      .OrderByDescending(t => t.Members.Count)
                                      .ThenBy(t => t.TeamName))
            {

                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");

                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }

            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teams.Where(t => t.Members.Count == 0).OrderBy(t => t.TeamName))
            {
                Console.WriteLine(team.TeamName);
            }

        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; } = new List<string>();

        public Team(string[] teamInfo)
        {
            this.CreatorName = teamInfo[0];
            this.TeamName = teamInfo[1];
        }

    }
}
