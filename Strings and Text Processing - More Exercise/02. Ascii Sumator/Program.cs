namespace _02._Ascii_Sumator
{
    using System;

    class Program
    {
        static void Main()
        {
            int firstCharNum = char.Parse(Console.ReadLine());
            int secondCharNum = char.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int sum = 0;

            foreach (var symbol in input)
            {
                if (symbol > Math.Min(firstCharNum, secondCharNum) && symbol < Math.Max(firstCharNum, secondCharNum))
                {
                    sum += symbol;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
