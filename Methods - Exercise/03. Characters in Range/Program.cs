namespace _03._Characters_in_Range
{
    using System;

    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintCharactersInBetwen(firstChar, secondChar);

        }

        static void PrintCharactersInBetwen(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                char temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }

            for (char i = (char)(firstChar + 1); i < secondChar; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
