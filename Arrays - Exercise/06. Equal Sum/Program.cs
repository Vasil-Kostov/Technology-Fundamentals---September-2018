namespace _06.Equal_Sum
{
    using System;
    using System.Linq;
    using System.Numerics;

    class Program
    {
        static void Main()
        {
            int[] numbersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (numbersArr.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = 0; i < numbersArr.Length; i++)
            {
                int leftSum = 0;

                for (int l = 0; l < i; l++)
                {
                    leftSum += numbersArr[l];
                }

                int rightSum = 0;

                for (int r = i + 1; r < numbersArr.Length; r++)
                {
                    rightSum += numbersArr[r];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}