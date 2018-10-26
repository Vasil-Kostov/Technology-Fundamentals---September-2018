namespace _01._Binary_Digits_Count
{
    using System;

    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            char  bDigit = char.Parse(Console.ReadLine());

            string numInBinary = Convert.ToString(num, 2);

            int counter = 0;

            foreach (var binDigit in numInBinary)
            {
                if (binDigit == bDigit)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
