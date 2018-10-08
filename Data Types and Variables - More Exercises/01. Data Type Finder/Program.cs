namespace _01.Data_Type_Finder
{
    using System;

    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (int.TryParse(input, out int noNeed1))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out double noNeed2))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out char noNeed3))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out bool noNeed4))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}