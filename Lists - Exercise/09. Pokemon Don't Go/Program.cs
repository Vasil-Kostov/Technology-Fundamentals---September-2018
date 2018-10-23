namespace _09._Pokemon_Don_t_Go
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<long> distances = Console.ReadLine()
                                  .Split()
                                  .Select(long.Parse)
                                  .ToList();
            long sum = 0;

            while (distances.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    long firstNum = distances.First();
                    sum += firstNum;
                    distances.RemoveAt(0);

                    IncraseOrDecrase(distances, firstNum);

                    distances.Insert(0, distances.Last());

                }
                else if (index > distances.Count - 1)
                {
                    long lastNum = distances.Last();
                    sum += lastNum;
                    distances.RemoveAt(distances.Count - 1);

                    IncraseOrDecrase(distances, lastNum);

                    distances.Add(distances.First());
                }
                else
                {
                    long removedNumber = distances[index];
                    sum += removedNumber;
                    distances.RemoveAt(index);

                    IncraseOrDecrase(distances, removedNumber);
                }
                
            }

            Console.WriteLine(sum);

        }

        private static void IncraseOrDecrase(List<long> distances, long removedNumber)
        {
            for (int i = 0; i < distances.Count; i++)
            {
                if (distances[i] <= removedNumber)
                {
                    distances[i] += removedNumber;
                }
                else
                {
                    distances[i] -= removedNumber;
                }
            }
        }
    }
}
