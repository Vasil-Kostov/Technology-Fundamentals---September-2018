namespace _10._Repeat_String
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());

            string result = RepeatTheString(text, repeats);

            Console.WriteLine(result);

        }

        static string RepeatTheString(string text, int repeats)
        {
            string result = string.Empty;

            for (int i = 0; i < repeats; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
