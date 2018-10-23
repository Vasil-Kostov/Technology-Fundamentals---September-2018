namespace _08._Anonymous_Threat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> data = Console.ReadLine().Split().ToList();

            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] command = input.Split();

                if (command[0] == "merge")
                {
                    MergeTheData(data, command);
                }
                else if (command[0] == "divide")
                {
                    DviideTheData(data, command);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", data));
        }

        private static void DviideTheData(List<string> data, string[] command)
        {
            int index = int.Parse(command[1]);
            int partitions = int.Parse(command[2]);

            List<char> dataToDivide = data[index].ToList();

            int subStringsLenght = data[index].Length / partitions;

            List<string> subStrings = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                string sub = string.Empty;

                for (int j = 0; j < subStringsLenght; j++)
                {
                    sub += dataToDivide[j];
                }
                subStrings.Add(sub);

                dataToDivide.RemoveRange(0, subStringsLenght);
            }

            for (int i = 0; i < dataToDivide.Count; i++)
            {
                subStrings[subStrings.Count - 1] += dataToDivide[i];
            }

            data.RemoveAt(index);
            data.InsertRange(index, subStrings);
            
        }

        private static void MergeTheData(List<string> data, string[] command)
        {
            int startIndex =
                        int.Parse(command[1]) >= 0
                        && int.Parse(command[1]) < data.Count ? int.Parse(command[1]) : 0;

            int endIndex =
                int.Parse(command[2]) < data.Count
                && int.Parse(command[2]) >= 0 ? int.Parse(command[2]) : data.Count - 1;

            int murges = endIndex - startIndex;

            for (int i = 0; i < murges; i++)
            {
                data[startIndex] += data[startIndex + 1];
                data.RemoveAt(startIndex + 1);
            }

        }
    }
}
