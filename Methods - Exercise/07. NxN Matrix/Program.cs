namespace _07._NxN_Matrix
{
    using System;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            PrintNxNMatrix(num);

        }

        private static void PrintNxNMatrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
