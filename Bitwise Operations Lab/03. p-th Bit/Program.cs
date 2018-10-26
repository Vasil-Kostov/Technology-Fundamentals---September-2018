namespace _03._p_th_Bit
{
    using System;

    class Program
    {
        static void Main()
        {
            uint num = uint.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            Console.WriteLine((num >> position) & 1);
        }
    }
}
