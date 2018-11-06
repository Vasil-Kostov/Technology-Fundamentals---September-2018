namespace _06._Students_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentInfo = input.Split();

                Student currentStudent = new Student(studentInfo);

                if (!students.Any(s => s.FirstName == currentStudent.FirstName 
                                    && s.LastName == currentStudent.LastName))
                {
                    students.Add(currentStudent);
                }
                else
                {
                    Student existing = students.Find(s => s.FirstName == currentStudent.FirstName && s.LastName == currentStudent.LastName);
                    
                    students[students.IndexOf(existing)] = currentStudent;
                }

                input = Console.ReadLine();
            }

            string studentsFromTown = Console.ReadLine();

            foreach (var student in students.Where(s => s.TownName == studentsFromTown))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string TownName { get; set; }

        public Student(string[] studentInfo)
        {
            this.FirstName = studentInfo[0];
            this.LastName = studentInfo[1];
            this.Age = int.Parse(studentInfo[2]);
            this.TownName = studentInfo[3];
        }
    }
}