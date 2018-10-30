namespace _07._Student_Academy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string studentName = Console.ReadLine();
                decimal studentGrade = decimal.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<decimal>());
                }

                students[studentName].Add(studentGrade);
            }

            foreach (var kvp in students.Where(kvp => kvp.Value.Average() >= 4.50m)
                                        .OrderByDescending(kvp => kvp.Value.Average()))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
            }

        }
    }
}
