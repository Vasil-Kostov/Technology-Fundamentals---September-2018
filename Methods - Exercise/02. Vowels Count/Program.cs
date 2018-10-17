namespace _02._Vowels_Count
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            PrintHowManyVowelsContains(input);

        }

        static void PrintHowManyVowelsContains(string input)
        {
            string vowels = "aeiouAEIOU";

            int result = 0;

            foreach (char symbol in input)
            {
                if (vowels.Contains(symbol))
                {
                    result++;
                }
            }

            Console.WriteLine(result);

        }
    }
}
