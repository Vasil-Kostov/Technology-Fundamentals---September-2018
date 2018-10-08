using System;

namespace _02.Circle_Area__Precision_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double circleArea = radius * radius * Math.PI;

            Console.WriteLine($"{circleArea:F12}");
            
        }
    }
}