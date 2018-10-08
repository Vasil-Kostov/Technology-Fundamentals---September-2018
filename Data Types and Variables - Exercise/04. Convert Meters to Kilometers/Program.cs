namespace _04.Convert_Meters_to_Kilometers
{
    using System;

    class Program
    {
        static void Main()
        {
            double meters = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{meters / 1000:F2}");
        }
    }
}