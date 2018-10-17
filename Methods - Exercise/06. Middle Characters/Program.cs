namespace _06._Middle_Characters
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            PrintMiddleCharacters(input);

        }

        private static void PrintMiddleCharacters(string input)
        {
            string result = string.Empty;
            if (input.Length % 2 == 0)
            {
                result = input[input.Length / 2 - 1] + input[input.Length / 2].ToString();
            }
            else
            {
                result = input[input.Length / 2].ToString();
            }

            Console.WriteLine(result);

        }
    }
}
