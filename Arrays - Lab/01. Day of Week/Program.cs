namespace _01.Day_of_Week
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string[] daysOfWeek = new string[] { "Monday", "Tuesday", "Wednesday",
                                        "Thursday", "Friday", "Saturday", "Sunday" };
            if (n > 0 && n < 8)
            {
                Console.WriteLine(daysOfWeek[n - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}