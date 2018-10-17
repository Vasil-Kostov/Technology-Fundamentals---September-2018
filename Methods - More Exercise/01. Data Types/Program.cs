namespace _01._Data_Types
{
    using System;

    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string input = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int number = int.Parse(input);
                    Execute(number);
                    break;
                case "real":
                    double realNumber = double.Parse(input);
                    Execute(realNumber);
                   break;
                case "string":
                    Execute(input);
                    break;
                default:
                    break;
            }
        }

        private static void Execute(string input)
        {
            Console.WriteLine("$" + input + "$");
        }

        private static void Execute(double realNumber)
        {
            Console.WriteLine($"{realNumber * 1.5:F2}");
        }

        private static void Execute(int number)
        {
            Console.WriteLine(number * 2);
        }
    }
}
