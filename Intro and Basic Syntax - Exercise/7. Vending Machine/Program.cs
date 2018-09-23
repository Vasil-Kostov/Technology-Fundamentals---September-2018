using System;

namespace _7.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal insertedSum = 0;

            string insertedMoney = Console.ReadLine();

            while (insertedMoney != "Start")
            {
                decimal currentInsert = decimal.Parse(insertedMoney);

                if (currentInsert == 0.1m || currentInsert == 0.2m || currentInsert == 0.5m
                    || currentInsert == 1m || currentInsert == 2m)
                {
                    insertedSum += currentInsert;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentInsert}");
                }

                insertedMoney = Console.ReadLine();
            }

            string purchase = Console.ReadLine();

            while (purchase != "End")
            {
                switch (purchase)
                {
                    case "Nuts":
                        if (insertedSum >= 2.0m)
                        {
                            Console.WriteLine("Purchased nuts");
                            insertedSum -= 2.0m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Water":
                        if (insertedSum >= 0.7m)
                        {
                            Console.WriteLine("Purchased water");
                            insertedSum -= 0.7m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Crisps":
                        if (insertedSum >= 1.5m)
                        {
                            Console.WriteLine("Purchased crisps");
                            insertedSum -= 1.5m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Soda":
                        if (insertedSum >= 0.8m)
                        {
                            Console.WriteLine("Purchased soda");
                            insertedSum -= 0.8m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    case "Coke":
                        if (insertedSum >= 1.0m)
                        {
                            Console.WriteLine("Purchased coke");
                            insertedSum -= 1.0m;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }

                purchase = Console.ReadLine();


            }

            Console.WriteLine($"Change: {insertedSum:F2}");

        }
    }
}