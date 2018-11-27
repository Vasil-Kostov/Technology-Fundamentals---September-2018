namespace _05._Multiply_Big_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            char[] numberCharArr = Console.ReadLine()
                                 .TrimStart('0')
                                 .ToCharArray()
                                 .Reverse()
                                 .ToArray();

            int multiplayer = int.Parse(Console.ReadLine());

            if (multiplayer == 0)
            {
                Console.WriteLine(0);
                return;
            }

            List<int> multiplicatinList = new List<int>();

            int remainder = 0;

            foreach (var digitChar in numberCharArr)
            {
                int digit = int.Parse(digitChar.ToString());

                int result = digit * multiplayer + remainder;

                remainder = result / 10;
                result = result % 10;

                multiplicatinList.Add(result);
            }

            if (remainder > 0)
            {
                multiplicatinList.Add(remainder);
            }

            multiplicatinList.Reverse();
            
            Console.WriteLine(string.Join(string.Empty, multiplicatinList));

        }
    }
}
