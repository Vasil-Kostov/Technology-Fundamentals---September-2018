namespace _05.Sum_Even_Numbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int sum = Console.ReadLine()
                      .Split()
                      .Select(int.Parse)
                      .Where(n => n % 2 == 0)
                      .Sum();

            Console.WriteLine(sum);
        }
    }
}