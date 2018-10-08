namespace _04.Floating_Equality
{
    using System;

    class Program
    {
        static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double precision = 0.000001;

            if (Math.Max(firstNumber, secondNumber) - Math.Min(firstNumber, secondNumber) <= precision)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}