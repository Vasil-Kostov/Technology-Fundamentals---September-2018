namespace _04._SoftUni_Bar_Income
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            Regex nameRegex = new Regex(@"\%([A-Z][a-z]+)\%");
            Regex productRegex = new Regex(@"<(\w+)>");
            Regex quantityRegex = new Regex(@"\|(\d+)\|");
            Regex priceRegex = new Regex(@"(\d+(\.?\d+)?)\$");

            decimal totalIncome = 0;

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                if (nameRegex.IsMatch(input) && productRegex.IsMatch(input) 
                    && quantityRegex.IsMatch(input) && priceRegex.IsMatch(input))
                {
                    string name = nameRegex.Match(input).Groups[1].ToString();
                    string product = productRegex.Match(input).Groups[1].ToString();
                    int quantity = int.Parse(quantityRegex.Match(input).Groups[1].ToString());
                    decimal price = decimal.Parse(priceRegex.Match(input).Groups[1].ToString());

                    decimal currentBill = quantity * price;

                    Console.WriteLine($"{name}: {product} - {currentBill:F2}");

                    totalIncome += currentBill;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
