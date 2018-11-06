namespace _04._Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                students.Add(new Student(Console.ReadLine().Split()));
            }

            foreach (var student in students.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string[] studentInfo)
        {
            this.FirstName = studentInfo[0];
            this.LastName = studentInfo[1];
            this.Grade = double.Parse(studentInfo[2]);
        }
    }
}
