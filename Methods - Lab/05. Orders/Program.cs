namespace _05._Orders
{
    using System;

    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    PintTotalPrice(quantity, 1.50);
                    break;
                case "coke":
                    PintTotalPrice(quantity, 1.40);
                    break;
                case "water":
                    PintTotalPrice(quantity, 1.00);
                    break;
                case "snacks":
                    PintTotalPrice(quantity, 2.00);
                    break;
                default:
                    break;
            }

        }

        private static void PintTotalPrice(int quantity, double price)
        {
            Console.WriteLine($"{quantity * price:F2}");
        }
    }
}
