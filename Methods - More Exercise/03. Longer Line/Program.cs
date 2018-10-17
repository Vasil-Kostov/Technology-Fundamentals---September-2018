namespace _03._Longer_Line
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
            double X3 = double.Parse(Console.ReadLine());
            double Y3 = double.Parse(Console.ReadLine());
            double X4 = double.Parse(Console.ReadLine());
            double Y4 = double.Parse(Console.ReadLine());

            double firstLineLength = FindLengthOfLine(X1, Y1, X2, Y2);
            double secondLineLength = FindLengthOfLine(X3, Y3, X4, Y4);

            if (secondLineLength > firstLineLength)
            {
                PrintLineCoordinatesWithTheClosestPointFirst(X3, Y3, X4, Y4);
            }
            else
            {
                PrintLineCoordinatesWithTheClosestPointFirst(X1, Y1, X2, Y2);
            }
        }

        private static double FindLengthOfLine(double x1, double y1, double x2, double y2)
        {
            double sideA = Math.Abs(x1 - x2);
            double sideB = Math.Abs(y1 - y2);

            double length = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return length;

        }


        private static void PrintLineCoordinatesWithTheClosestPointFirst(double x1, double y1, double x2, double y2)
        {
            double firstPointDistance = CalculateDistanceFromThecenter(x1, y1);
            double secondPointDistance = CalculateDistanceFromThecenter(x2, y2);

            if (secondPointDistance < firstPointDistance)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

        private static double CalculateDistanceFromThecenter(double x1, double y1)
        {
            double distance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));

            return distance;
        }
    }
}
