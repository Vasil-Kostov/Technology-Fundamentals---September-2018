namespace _01._Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            string text = Console.ReadLine();

            string result = string.Empty;

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = GetDigitsSum(numbers[i]);

                int realIndex = index % text.Length;

                result += text[realIndex];

                text = GetRestOfTheText(text, realIndex);

            }

            Console.WriteLine(result);

        }

        private static string GetRestOfTheText(string text, int realIndex)
        {
            string restOfText = "";

            for (int i = 0; i < realIndex; i++)
            {
                restOfText += text[i];
            }

            for (int i = realIndex + 1; i < text.Length; i++)
            {
                restOfText += text[i];
            }

            return restOfText;

        }
        
        private static int GetDigitsSum(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            return sum;

        }
    }
}
