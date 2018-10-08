namespace _06.Reversed_Chars
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<char> chars = new List<char>();

            for (int i = 0; i < 3; i++)
            {
                chars.Insert(0, char.Parse(Console.ReadLine()));
            }
            
            Console.WriteLine(string.Join(" ", chars));
        }
    }
}