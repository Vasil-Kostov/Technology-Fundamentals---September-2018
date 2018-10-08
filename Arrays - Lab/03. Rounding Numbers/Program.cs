namespace _03.Rounding_Numbers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            double[] realNumbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            for (int i = 0; i < realNumbers.Length; i++)
            {
                Console.WriteLine($"{realNumbers[i]} => {Math.Round(realNumbers[i], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}