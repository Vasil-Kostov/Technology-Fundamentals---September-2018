namespace _05._Odd_Times
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            uint[] nums = Console.ReadLine()
                          .Split()
                          .Select(uint.Parse)
                          .ToArray();

            uint result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }

            Console.WriteLine(result);
        }
    }
}
