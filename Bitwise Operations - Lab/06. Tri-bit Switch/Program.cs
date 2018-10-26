namespace _06._Tri_bit_Switch
{
    using System;

    class Program
    {
        static void Main()
        {
            uint num = uint.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                uint bit = (num >> i + position) & 1;

                uint mask = (uint)1 << i + position;

                if (bit == 1)
                {
                    num = num & ~(mask);
                }
                else
                {
                    num = num | mask;
                }
            }

            Console.WriteLine(num);

        }
    }
}
