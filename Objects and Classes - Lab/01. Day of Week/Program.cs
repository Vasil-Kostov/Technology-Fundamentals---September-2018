namespace _01._Day_of_Week
{
    using System;

    class Program
    {
        static void Main()
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-MM-yyyy", null);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
