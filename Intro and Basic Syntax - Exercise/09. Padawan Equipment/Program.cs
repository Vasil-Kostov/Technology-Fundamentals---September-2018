using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double chosMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabrePtice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int lightsabrestToBuy = (int)Math.Ceiling(students * 1.1);
            int robesToBuy = students;
            int beltsToPayFor = students - (students / 6);

            double totalMoneyNeededForEqupment =
                lightsabrestToBuy * lightsabrePtice
                + robesToBuy * robePrice
                + beltsToPayFor * beltPrice;

            if (chosMoney >= totalMoneyNeededForEqupment)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeededForEqupment:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalMoneyNeededForEqupment - chosMoney:F2}lv more.");
            }


        }
    }
}