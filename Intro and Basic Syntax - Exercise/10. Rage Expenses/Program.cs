using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousetPrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double expenseForHeadsets = (numberOfLostGames / 2) * headsetPrice;
            double expenseForMouses = (numberOfLostGames / 3) * mousetPrice;
            double expenseForKeyboards = (numberOfLostGames / 6) * keyboardPrice;
            double expenseForDisplays = (numberOfLostGames / 12) * displayPrice;

            double totalExpenses = expenseForHeadsets + expenseForMouses + expenseForKeyboards + expenseForDisplays;

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}