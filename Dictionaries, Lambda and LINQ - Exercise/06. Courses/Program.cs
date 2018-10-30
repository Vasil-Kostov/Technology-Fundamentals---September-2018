namespace _06._Courses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                string[] inputArray = inputLine.Split(" : ");
                string course = inputArray[0];
                string student = inputArray[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }

                courses[course].Add(student);

                inputLine = Console.ReadLine();
            }

            foreach (var kvp in courses.OrderByDescending(kvp => kvp.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var student in kvp.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
