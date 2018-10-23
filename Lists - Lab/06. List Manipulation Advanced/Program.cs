namespace _06._List_Manipulation_Advanced
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

            bool anyChangesMade = false;

            while (command != "end")
            {
                string[] commandArr = command.Split();

                switch (commandArr[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(commandArr[1]));
                        anyChangesMade = true;
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(commandArr[1]));
                        anyChangesMade = true;
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(commandArr[1]));
                        anyChangesMade = true;
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(commandArr[2]), int.Parse(commandArr[1]));
                        anyChangesMade = true;
                        break;
                    case "Contains":
                        Console.WriteLine(numbers.Contains(int.Parse(commandArr[1])) ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 1)));
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        if (commandArr[1] == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n > int.Parse(commandArr[2]))));
                        }
                        else if (commandArr[1] == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n < int.Parse(commandArr[2]))));
                        }
                        else if (commandArr[1] == "<=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= int.Parse(commandArr[2]))));
                        }
                        else if (commandArr[1] == ">=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n >= int.Parse(commandArr[2]))));
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();

            }

            if (anyChangesMade)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
