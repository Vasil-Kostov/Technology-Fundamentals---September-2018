namespace _09._Palindrome_Integers
{
    using System;
    using System.Linq;
    
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                int number = int.Parse(input);

                IsTheNumberPolindrome(number, input);

                input = Console.ReadLine();
            }
        }

        private static void IsTheNumberPolindrome(int number, string numAsString)
        {
            int reversedNum = ReveseTheInputNumber(numAsString);

            if (number == reversedNum)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }

        private static int ReveseTheInputNumber(string numAsString)
        {
            string numStr = string.Empty;

            for (int i = numAsString.Length - 1; i >= 0; i--)
            {
                numStr += numAsString[i];
            }

            return int.Parse(numStr);

        }
    }
}
