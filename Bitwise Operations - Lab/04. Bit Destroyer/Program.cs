namespace _04._Bit_Destroyer
{
    using System;

    class Program
    {
        static void Main()
        {
            uint num = uint.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            uint mask = (uint)1 << position;

            Console.WriteLine(num & ~(mask));

        }
    }
}
