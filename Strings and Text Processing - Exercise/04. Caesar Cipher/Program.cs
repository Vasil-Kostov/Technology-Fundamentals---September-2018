namespace _04._Caesar_Cipher
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine()
                           .ToCharArray()
                           .Select(c => Convert.ToChar(c + 3))
                           .ToArray();

            Console.WriteLine(input);
        }
    }
}
