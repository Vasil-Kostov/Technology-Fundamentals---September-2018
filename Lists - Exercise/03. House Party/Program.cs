namespace _03._House_Party
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<string> guests = new List<string>();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                string[] commandAsStrArray = command.Split();
                string name = commandAsStrArray[0];

                if (command.EndsWith("is not going!"))
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (!guests.Contains(name))
                    {
                        guests.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));

        }
    }
}
