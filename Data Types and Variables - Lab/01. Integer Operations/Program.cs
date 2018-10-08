using System;

namespace _01.Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            long result = firstNumber + secondNumber;
            result /= thirdNumber;
            result *= fourthNumber;

            Console.WriteLine(result);
        }
    }
}