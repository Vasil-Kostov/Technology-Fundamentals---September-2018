namespace _02._Center_Point
{
    using System;

    class Program
    {
        static void Main()
        {
            double X1 = double.Parse(Console.ReadLine());
            double Y1 = double.Parse(Console.ReadLine());
            double X2 = double.Parse(Console.ReadLine());
            double Y2 = double.Parse(Console.ReadLine());

            PrintWhichPontIsCloserToTheCenter(X1, Y1, X2, Y2);
        }

        private static void PrintWhichPontIsCloserToTheCenter(double x1, double y1, double x2, double y2)
        {
            double firstPointDistance = CalculateDistanceFromThecenter(x1, y1);
            double secondPointDistance = CalculateDistanceFromThecenter(x2, y2);

            if (secondPointDistance < firstPointDistance)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }

        private static double CalculateDistanceFromThecenter(double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

            return distance;
        }
    }
}
