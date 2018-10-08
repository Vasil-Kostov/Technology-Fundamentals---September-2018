namespace _05.Pounds_to_Dollars
{
    using System;

    class Program
    {
        static void Main()
        {
            decimal pound = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"{pound * 1.31m:F3}");
        }
    }
}