namespace _03._Calculations
{
    using System;

    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddTwoNumbers(firstNum, secondNum);
                    break;
                case "multiply":
                    MultiplyTwoNumbers(firstNum, secondNum);
                    break;
                case "subtract":
                    SubtractTwoNumbers(firstNum, secondNum);
                    break;
                case "divide":
                    DivideTwoNumbers(firstNum, secondNum);
                    break;
                default:
                    break;
            }
        }

        private static void DivideTwoNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }

        private static void SubtractTwoNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

        private static void MultiplyTwoNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }

        private static void AddTwoNumbers(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
    }
}
