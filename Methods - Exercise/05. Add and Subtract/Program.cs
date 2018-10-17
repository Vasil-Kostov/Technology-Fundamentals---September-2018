namespace _05._Add_and_Subtract
{
    using System;

    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int sum = SumTwoNumbers(firstNum, secondNum);
            int result = SubtractTwoNumbers(sum, thirdNum);

            Console.WriteLine(result);

        }

        private static int SubtractTwoNumbers(int sum, int thirdNum)
        {
            return sum - thirdNum;
        }

        private static int SumTwoNumbers(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
    }
}
