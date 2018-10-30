namespace _05._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, string> parked = new Dictionary<string, string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string username = command[1];

                if (command[0] == "register")
                {
                    string licensePlateNumber = command[2];

                    if (!parked.ContainsKey(username))
                    {
                        parked.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parked[username]}");
                    }

                }
                else if (command[0] == "unregister")
                {
                    if (parked.ContainsKey(username))
                    {
                        parked.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var user in parked)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }

        }
    }
}
