namespace _01.Train
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int numberOfWagons = int.Parse(Console.ReadLine());

            int[] wagons = new int[numberOfWagons];

            for (int i = 0; i < numberOfWagons; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(wagons.Sum());
        }
    }
}