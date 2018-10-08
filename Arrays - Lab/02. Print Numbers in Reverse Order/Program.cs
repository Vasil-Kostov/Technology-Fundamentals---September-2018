
namespace _02.Print_Numbers_in_Reverse_Order
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] numbers = new string[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(" ", numbers.Reverse()));
        }
    }
}