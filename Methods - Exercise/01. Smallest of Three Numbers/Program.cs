namespace _01._Smallest_of_Three_Numbers
{
    using System;

    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int smallestNum = GetSmallestNumber(firstNum, secondNum, thirdNum);
            
            Console.WriteLine(smallestNum);
        }

        static int GetSmallestNumber(int firstNum, int secondNum, int thirdNum)
        {
            int result = Math.Min(firstNum, Math.Min(secondNum, thirdNum));

            return result;
        }
    }
}
