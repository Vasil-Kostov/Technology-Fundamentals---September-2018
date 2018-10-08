namespace _04.Array_Rotation
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {
                int temp = numbers[0];

                for (int j = 1; j < numbers.Length; j++)
                {
                    numbers[j - 1] = numbers[j];
                }

                numbers[numbers.Length - 1] = temp;

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}