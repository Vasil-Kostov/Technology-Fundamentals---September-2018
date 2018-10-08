namespace _07.Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int longestSequenceStart = 0;
            int longestSequenceLenth = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                int currentStart = i;
                int currentSequenceLength = 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        currentSequenceLength++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentSequenceLength > longestSequenceLenth)
                {
                    longestSequenceStart = currentStart;
                    longestSequenceLenth = currentSequenceLength;
                }
            }

            for (int i = longestSequenceStart; i < longestSequenceStart + longestSequenceLenth; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();
        }
    }
}