namespace _04.Reverse_Array_of_Strings
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();

            Console.WriteLine(string.Join(" ", input));
        }
    }
}