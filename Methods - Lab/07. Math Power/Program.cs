namespace _07._Math_Power
{
    using System;

    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = NumberRaisedToPower(number, power);

            Console.WriteLine(result);

        }

        static double NumberRaisedToPower(double number, int power)
        {
            double result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            return result;

        }
    }
}
