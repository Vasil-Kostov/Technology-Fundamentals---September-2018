namespace _02._Repeat_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine()
                                 .Split()
                                 .ToList();

            foreach (var str in input)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    Console.Write(str);
                }
            }
            Console.WriteLine();
        }
    }
}
