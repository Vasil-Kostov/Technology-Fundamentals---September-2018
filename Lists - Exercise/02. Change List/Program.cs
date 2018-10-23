namespace _02._Change_List
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

            while (inputLine != "end")
            {
                string[] command = inputLine.Split();

                switch (command[0])
                {
                    case "Delete":
                        numbers.RemoveAll(n => n == int.Parse(command[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    default:
                        break;
                }


                inputLine = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
