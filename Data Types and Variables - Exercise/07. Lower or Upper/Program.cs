namespace _07.Lower_or_Upper
{
    using System;

    class Program
    {
        static void Main()
        {
            char input = char.Parse(Console.ReadLine());

            Console.WriteLine(input >= 'a' ? "lower-case" : "upper-case");
        }
    }
}