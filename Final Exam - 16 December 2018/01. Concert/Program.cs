namespace _01._Concert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> bandAndMembers = new Dictionary<string, List<string>>();
            Dictionary<string, long> bandAndTime = new Dictionary<string, long>();

            string input = Console.ReadLine();

            while (input != "start of concert")
            {
                string[] inputArr = input.Split("; ");
                string command = inputArr[0];
                string name = inputArr[1];

                if (command == "Add")
                {
                    if (!bandAndMembers.ContainsKey(name))
                    {
                        bandAndMembers.Add(name, new List<string>());
                        bandAndTime.Add(name, 0);
                    }

                    string[] members = inputArr[2].Split(", ");

                    foreach (var member in members)
                    {
                        if (!bandAndMembers[name].Contains(member))
                        {
                            bandAndMembers[name].Add(member);
                        }
                    }
                }
                else if (command == "Play")
                {
                    if (!bandAndTime.ContainsKey(name))
                    {
                        bandAndMembers.Add(name, new List<string>());
                        bandAndTime.Add(name, 0);
                    }

                    int time = int.Parse(inputArr[2]);
                    bandAndTime[name] += time;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total time: {bandAndTime.Values.Sum()}");

            foreach (var band in bandAndTime.OrderByDescending(kvp => kvp.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string bandToPrint = Console.ReadLine();

            List<string> membersToPrint = bandAndMembers.FirstOrDefault(b => b.Key == bandToPrint).Value;

            Console.WriteLine(bandToPrint);

            foreach (var member in membersToPrint)
            {
                Console.WriteLine($"=> {member}");
            }

        }
    }
}
