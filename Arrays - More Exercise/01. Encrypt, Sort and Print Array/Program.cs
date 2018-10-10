namespace _01.Encrypt__Sort_and_Print_Array
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] strArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                strArray[i] = Console.ReadLine();
            }

            int[] encrypted = new int[n];

            for (int i = 0; i < n; i++)
            {
                encrypted[i] = EncryptTheString(strArray[i]);
            }

            foreach (var enc in encrypted.OrderBy(e => e))
            {
                Console.WriteLine(enc);
            }
        }

        static int EncryptTheString(string str)
        {
            int sum = 0;

            foreach (var symbol in str)
            {
                if (IsVowel(symbol))
                {
                    sum += (int)symbol * str.Length;
                }
                else
                {
                    sum += (int)symbol / str.Length;
                }
            }

            return sum;

        }

        static bool IsVowel(char symbol)
        {
            char[] vowels = "aeiouAEIOU".ToCharArray();

            if (vowels.Contains(symbol))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}