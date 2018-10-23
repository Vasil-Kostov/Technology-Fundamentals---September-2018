namespace _05._List_Manipulation_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArr = command.Split();

                switch (commandArr[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commandArr[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(commandArr[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commandArr[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commandArr[2]), int.Parse(commandArr[1]));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", numbers));
            
        }
    }
}
