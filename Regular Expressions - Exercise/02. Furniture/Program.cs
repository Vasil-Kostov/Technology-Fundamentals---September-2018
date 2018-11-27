namespace _02._Furniture
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex orderRegex = new Regex(@"^>>(\w+)<<(\d+(\.\d+)?)!(\d+)\b");

            List<string> purchased = new List<string>();

            decimal totalSpend = 0;

            string input = Console.ReadLine();

            while (input != "Purchase")
            {
                if (orderRegex.IsMatch(input))
                {
                    int amount = int.Parse(orderRegex.Match(input).Groups[4].ToString());

                    if (amount > 0)
                    {
                        string furnitureName = orderRegex.Match(input).Groups[1].ToString();
                        purchased.Add(furnitureName);

                        decimal price = decimal.Parse(orderRegex.Match(input).Groups[2].ToString());

                        totalSpend += price * amount;
                    }
                }

                input = Console.ReadLine();
            }


            Console.WriteLine("Bought furniture:");
            if (purchased.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, purchased));
            }
            Console.WriteLine($"Total money spend: {totalSpend:F2}");
        }
    }
}
