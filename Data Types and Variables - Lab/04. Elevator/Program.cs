using System;

namespace _04.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling(numberOfPeople / capacity);

            Console.WriteLine(courses);
        }
    }
}