namespace _11._Math_operations
{
    using System;

    class Program
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int secondNum = int.Parse(Console.ReadLine());

            double result = Calculate(firstNum, @operator, secondNum);

            Console.WriteLine(result);

        }

        static double Calculate(int firstNum, string @operator, int secondNum)
        {
            double result = 0;

            switch (@operator)
            {
                case "*":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    result = firstNum / secondNum;
                    break;
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
