namespace _01._Party_Profit
{
    using System;

    class Program
    {
        static void Main()
        {
            int partySize = int.Parse(Console.ReadLine());
            int daysOfAdventure = int.Parse(Console.ReadLine());

            int coins = 0;

            for (int i = 1; i <= daysOfAdventure; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }

                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                coins += 50;
                coins -= partySize * 2;

                if (i % 3 == 0)
                {
                    coins -= partySize * 3;
                }

                if (i % 5 == 0)
                {
                    coins += partySize * 20;
                    if (i % 3 == 0)
                    {
                        coins -= 2 * partySize;
                    }
                }

            }

            Console.WriteLine($"{partySize} companions received {coins / partySize} coins each.");
        }
    }
}
