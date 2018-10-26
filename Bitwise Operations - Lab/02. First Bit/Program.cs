namespace _02._First_Bit
{
    using System;

    class Program
    {
        static void Main()
        {
            uint num = uint.Parse(Console.ReadLine());

            Console.WriteLine((num >> 1) & 1);
        }
    }
}
