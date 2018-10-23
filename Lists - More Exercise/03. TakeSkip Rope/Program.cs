namespace _03._TakeSkip_Rope
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            string digitsAsStr = string.Join(" ", input.Where(x => x >= '0' && x <= '9').ToList());
            string messageWithoutDigits = string.Join("", input.Where(x => !(x >= '0' && x <= '9')).ToList());

            int[] nums = digitsAsStr.Split().Select(int.Parse).ToArray();

            string result = string.Empty;

            for (int i = 0; i < nums.Length - 1; i += 2) 
            {
                result += string.Join("", messageWithoutDigits.Take(nums[i]));
                if (messageWithoutDigits.Length < nums[i] + nums[i + 1])
                {
                    break;
                }
                messageWithoutDigits = messageWithoutDigits.Substring(nums[i] + nums[i + 1]);

            }

            Console.WriteLine(result);
        }


    }
}
