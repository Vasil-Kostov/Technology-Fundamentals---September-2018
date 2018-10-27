namespace _01._Baking_Masterclass
{
    using System;

    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            int apronsToBy = (int)Math.Ceiling(students * 1.2);
            int flourToBy = students - (students / 5);

            double totalPrice = (apronPrice * apronsToBy) + (flourPrice * flourToBy) + (eggPrice * students * 10);

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Items purchased for {totalPrice:F2}$.");
            }
            else
            {
                Console.WriteLine($"{totalPrice - budget:F2}$ more needed.");
            }

        }
    }
}
