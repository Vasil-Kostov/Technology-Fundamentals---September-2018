namespace _02.Chars_to_String
{
    using System;

    class Program
    {
        static void Main()
        {
            string result = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                result += Console.ReadLine();
            }

            Console.WriteLine(result);

        }
    }
}