namespace _04.Longest_Increasing_Subsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numsArray = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

            List<int> lenghtOfSequenceEndingInThisIndex = new int[numsArray.Length].ToList();

            for (int i = 0; i < lenghtOfSequenceEndingInThisIndex.Count; i++)
            {
                lenghtOfSequenceEndingInThisIndex[i] = 1;
            }

            int[] previousElementOfTheSequence = new int[numsArray.Length];

            for (int i = 1; i < numsArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numsArray[j] < numsArray[i])
                    {
                        if (lenghtOfSequenceEndingInThisIndex[i] < lenghtOfSequenceEndingInThisIndex[j] + 1)
                        {
                            lenghtOfSequenceEndingInThisIndex[i] = lenghtOfSequenceEndingInThisIndex[j] + 1;
                            previousElementOfTheSequence[i] = j;
                        }
                    }
                }
            }

            int longestSubsequence = lenghtOfSequenceEndingInThisIndex.Max();
            int index = lenghtOfSequenceEndingInThisIndex.IndexOf(longestSubsequence);

            List<int> LIS = new List<int>();

            for (int i = 0; i < longestSubsequence; i++)
            {
                LIS.Add(numsArray[index]);
                index = previousElementOfTheSequence[index];
            }

            LIS.Reverse();

            Console.WriteLine(string.Join(" ", LIS));

        }
    }
}