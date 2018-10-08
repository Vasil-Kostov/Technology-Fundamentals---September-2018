namespace _08.Condense_Array_to_Number
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] conensed = new int[numbers.Length - 1];

                for (int i = 0; i < conensed.Length; i++)
                {
                    conensed[i] = numbers[i] + numbers[i + 1];
                }

                numbers = conensed;

            }

            Console.WriteLine(numbers[0]);
        }
    }
}