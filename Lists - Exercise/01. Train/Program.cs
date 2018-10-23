namespace _01._Train
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> wagons = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToList();

            int wagonLimit = int.Parse(Console.ReadLine());

            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] command = line.Split();

                if (command[0] == "Add")
                {
                    wagons.Add(int.Parse(command[1]));
                }
                else
                {
                    int passangers = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= wagonLimit)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));

        }
    }
}
