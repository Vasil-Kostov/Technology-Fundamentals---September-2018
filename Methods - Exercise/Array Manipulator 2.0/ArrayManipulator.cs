namespace Array_Manipulator_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandSequence = command.Split();

                switch (commandSequence[0])
                {
                    case "exchange":
                        numbers = ExchangeNumbers(numbers, int.Parse(commandSequence[1]));                        
                        break;
                    case "max":
                    case "min":
                        PrintMaxMinOddOrEven(numbers, commandSequence[0], commandSequence[1]);
                        break;
                    case "first":
                    case "last":
                        PrinFirstOrLastNEvensOrOdds(numbers, commandSequence[0], int.Parse(commandSequence[1]), commandSequence[2]);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }

        public static void PrinFirstOrLastNEvensOrOdds(List<int> numbers, string firstOrLast, int amountOfNumbers, string evensOrOdds)
        {
            int remainder = evensOrOdds == "even" ? 0 : 1;
            if (amountOfNumbers > numbers.Count)
            {
                Console.WriteLine("Invalid count");
            }
            else if (firstOrLast == "first")
            {
                Console.WriteLine($"[{string.Join(", ", numbers.Where(n => n % 2 == remainder).Take(amountOfNumbers).ToList())}]");
            }
            else if (firstOrLast == "last")
            {
                Console.WriteLine($"[{string.Join(", ", numbers.Where(n => n % 2 == remainder).TakeLast(amountOfNumbers).ToList())}]");
            }            
        }

        public static void PrintMaxMinOddOrEven(List<int> numbers, string minOrMax, string oddOrEven)
        {
            int remainder = oddOrEven == "even" ? 0 : 1;

            if (!numbers.Any(n => n % 2 == remainder))
            {
                Console.WriteLine("No matches");
            }
            else if (minOrMax == "min")
            {
                int min = numbers.Where(n => n % 2 == remainder).Min();
                Console.WriteLine(numbers.LastIndexOf(min));
            }
            else if (minOrMax == "max")
            {
                int max = numbers.Where(n => n % 2 == remainder).Max();
                Console.WriteLine(numbers.LastIndexOf(max));
            }
        }

        public static List<int> ExchangeNumbers(List<int> numbers, int index)
        {
            if (index < 0 || index > numbers.Count - 1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                List<int> exchanged = numbers.Skip(index + 1).Take(numbers.Count - index - 1).ToList();
                exchanged.AddRange(numbers.Take(index + 1));
                numbers = exchanged;
            }

            return numbers;
        }
    }
}
