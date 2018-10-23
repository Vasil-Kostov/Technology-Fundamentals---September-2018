namespace _04._List_Operations
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

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] operation = inputLine.Split();

                switch (operation[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(operation[1]));
                        break;

                    case "Insert":
                        if (int.Parse(operation[2]) >= 0 && int.Parse(operation[2]) < numbers.Count)
                        {
                            numbers.Insert(int.Parse(operation[2]), int.Parse(operation[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Remove":
                        if (int.Parse(operation[1]) >= 0 && int.Parse(operation[1]) < numbers.Count)
                        {
                            numbers.RemoveAt(int.Parse(operation[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;

                    case "Shift":
                        ShiftTheColection(numbers, operation[1], int.Parse(operation[2]));
                        break;

                    default:
                        break;
                }

                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ShiftTheColection(List<int> numbers, string direction, int count)
        {
            if (direction == "left")
            {
                for (int i = 0; i < count; i++)
                {
                    int firstNum = numbers[0];
                    numbers.Remove(firstNum);
                    numbers.Add(firstNum);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    int lastNumber = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(0, lastNumber);
                }
            }

        }
    }
}
