namespace _05.Top_Integers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbersArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            List<int> topIntegers = new List<int>();

            bool isTopInteger = true;

            for (int i = 0; i < numbersArr.Length; i++)
            {
                for (int j = i + 1; j < numbersArr.Length; j++)
                {
                    if (numbersArr[i] <= numbersArr[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    topIntegers.Add(numbersArr[i]);
                }

                isTopInteger = true;
            }

            Console.WriteLine(string.Join(" ", topIntegers));
            
        }
    }
}