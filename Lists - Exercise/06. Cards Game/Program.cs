namespace _06._Cards_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<int> firstPlayerCards = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToList();

            List<int> secondPlayerCards = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToList();

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                int firstPrayerCard = firstPlayerCards[0];
                int secondPlayerCard = secondPlayerCards[0];

                firstPlayerCards.RemoveAt(0);
                secondPlayerCards.RemoveAt(0);

                if (firstPrayerCard > secondPlayerCard)
                {
                    firstPlayerCards.Add(firstPrayerCard);
                    firstPlayerCards.Add(secondPlayerCard);
                }
                else if (firstPrayerCard < secondPlayerCard)
                {
                    secondPlayerCards.Add(secondPlayerCard);
                    secondPlayerCards.Add(firstPrayerCard);
                }
            }

            if (firstPlayerCards.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
            else if (secondPlayerCards.Count > 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }
        }
    }
}
