using System;
using System.Globalization;

namespace _13.Price_Change_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPrices = int.Parse(Console.ReadLine());

            double sigThreshold = double.Parse(Console.ReadLine());

            double previousPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPrices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());

                double percentOfDifference = PercentOfDifference(previousPrice, currentPrice);

                bool isTheDifferenceSignificant = areDifferent(percentOfDifference, sigThreshold);

                string message = GetMessage(currentPrice, previousPrice, percentOfDifference, isTheDifferenceSignificant);
                Console.WriteLine(message);

                previousPrice = currentPrice;
            }
        }

        static string GetMessage(double currentPrice, double previousPrice,
                                    double percentOfDifference, bool isTheDifferenceSignificant)
        {
            string message = "";

            if (percentOfDifference == 0.0)
            {
                message = string.Format($"NO CHANGE: {currentPrice}");

            }
            else if (isTheDifferenceSignificant && (percentOfDifference > 0))
            {
                message = string.Format($"PRICE UP: {previousPrice} to {currentPrice} ({percentOfDifference * 100:F2}%)");

            }
            else if (isTheDifferenceSignificant && (percentOfDifference < 0))
            {
                message = string.Format($"PRICE DOWN: {previousPrice} to {currentPrice} ({percentOfDifference * 100:F2}%)");

            }
            else
            {
                message = string.Format($"MINOR CHANGE: {previousPrice} to {currentPrice} ({percentOfDifference * 100:F2}%)");

            }

            return message;

        }

        static bool areDifferent(double percentOfDifference, double sigThreshold)
        {
            if (Math.Abs(percentOfDifference) >= sigThreshold)
            {
                return true;
            }
            return false;
        }

        static double PercentOfDifference(double previousPrice, double currentPrice)
        {
            double result = (currentPrice - previousPrice) / previousPrice;

            return result;
        }
    }
}
