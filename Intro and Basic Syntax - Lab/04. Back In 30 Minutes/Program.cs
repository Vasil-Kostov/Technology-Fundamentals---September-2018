using System;

namespace _04.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeInMinutes = 60 * int.Parse(Console.ReadLine());
            timeInMinutes += int.Parse(Console.ReadLine());
            timeInMinutes += 30;

            int hours = timeInMinutes / 60 > 23 ? timeInMinutes / 60 - 24 : timeInMinutes / 60;

            Console.WriteLine($"{hours}:{timeInMinutes % 60:D2}");
        }
    }
}