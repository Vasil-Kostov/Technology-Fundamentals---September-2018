namespace _03._Baking_Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int[]> batches = new List<int[]>();

            string inputLine = Console.ReadLine();

            while (inputLine != "Bake It!")
            {
                int[] currentBatch = inputLine
                                     .Split('#')
                                     .Select(int.Parse)
                                     .ToArray();

                batches.Add(currentBatch);

                inputLine = Console.ReadLine();
            }

            List<int> topBatch = batches[0].ToList();

            for (int i = 1; i < batches.Count; i++)
            {
                if (topBatch.Sum() < batches[i].Sum())
                {
                    topBatch = batches[i].ToList();
                }
                else if (topBatch.Sum() == batches[i].Sum())
                {
                    if (topBatch.Average() < batches[i].Average())
                    {
                        topBatch = batches[i].ToList();
                    }
                    else if (topBatch.Average() == batches[i].Average())
                    {
                        if (topBatch.Count > batches[i].Length)
                        {
                            topBatch = batches[i].ToList();
                        }
                    }
                }
            }

            Console.WriteLine($"Best Batch quality: {topBatch.Sum()}");
            Console.WriteLine(string.Join(" ", topBatch));

        }
    }
}
