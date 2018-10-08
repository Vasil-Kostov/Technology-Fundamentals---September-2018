namespace _03.Zig_Zag_Arrays
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                if (i % 2 == 0) 
                {
                    firstArr[i] = input[0];
                    secondArr[i] = input[1];
                }
                else
                {
                    firstArr[i] = input[1];
                    secondArr[i] = input[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}