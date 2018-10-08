namespace _03.Exchange_Integers
{
    using System;

    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before:\n" +
                               $"a = {a} \n" +
                               $"b = {b}");

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After:\n" +
                              $"a = {a} \n" +
                              $"b = {b}");
        }
    }
}