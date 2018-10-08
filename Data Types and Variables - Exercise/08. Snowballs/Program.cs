namespace _08.Snowballs
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            int bestSnow = 0;
            int bestTime = 0;
            int bestQuality = 0;
            BigInteger bestValue = 0;

            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int currentSnow = int.Parse(Console.ReadLine());
                int currentTime = int.Parse(Console.ReadLine());
                int currentQuality = int.Parse(Console.ReadLine());

                BigInteger currentValue = BigInteger.Pow((currentSnow / currentTime), currentQuality);

                if (currentValue > bestValue)
                {
                    bestSnow = currentSnow;
                    bestTime = currentTime;
                    bestQuality = currentQuality;
                    bestValue = currentValue;
                }
            }

            Console.WriteLine($"{bestSnow} : {bestTime} = {bestValue} ({bestQuality})");
        }
    }
}