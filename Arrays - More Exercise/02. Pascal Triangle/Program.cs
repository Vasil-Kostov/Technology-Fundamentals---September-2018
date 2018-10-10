namespace _02.Pascal_Triangle
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            int numberToPrint = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0) 
                    {
                        numberToPrint = 1;
                    }
                    else
                    {
                        numberToPrint = numberToPrint * (i - j + 1) / j;
                    }

                    Console.Write($"{numberToPrint} ");

                }

                Console.WriteLine();

            }
        }
    }
}