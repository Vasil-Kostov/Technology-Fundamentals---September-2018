namespace _08.Magic_Sum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if ((array[i] + array[j]) == magicSum)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                }
            }
        }
    }
}