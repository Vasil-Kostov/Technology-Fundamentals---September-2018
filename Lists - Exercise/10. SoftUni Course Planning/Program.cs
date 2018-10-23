namespace _10._SoftUni_Course_Planning
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<string> courses = Console.ReadLine()
                                   .Split(", ")
                                   .ToList();

            string inputLine = Console.ReadLine();

            while (inputLine != "course start")
            {
                string[] command = inputLine.Split(":").ToArray();
                string lessonTitle = command[1];

                switch (command[0])
                {
                    case "Add":
                        if (!courses.Contains(lessonTitle))
                        {
                            courses.Add(lessonTitle);
                        }
                        break;

                    case "Insert":
                        if (!courses.Contains(lessonTitle))
                        {
                            courses.Insert(int.Parse(command[2]),lessonTitle);
                        }
                        break;

                    case "Remove":
                        if (courses.Contains(lessonTitle))
                        {
                            courses.Remove(lessonTitle);

                            if (courses.Contains(lessonTitle + "-Exercise"))
                            {
                                courses.Remove(lessonTitle + "-Exercise");
                            }
                        }
                        break;

                    case "Swap":
                        string secondLessonTitle = command[2];
                        if (courses.Contains(lessonTitle) && courses.Contains(secondLessonTitle))
                        {
                            SwapCourses(courses, lessonTitle, secondLessonTitle);
                        }
                        break;

                    case "Exercise":
                        if (!courses.Contains(lessonTitle))
                        {
                            courses.Add(lessonTitle);
                            courses.Add(lessonTitle + "-Exercise");
                        }
                        else if (courses.Contains(lessonTitle) && !courses.Contains(lessonTitle + "-Exercise"))
                        {
                                int index = courses.IndexOf(lessonTitle);
                                courses.Insert(index + 1, lessonTitle + "-Exercise");
                        }
                        break;

                    default:
                        break;
                }

                inputLine = Console.ReadLine();
            }

            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i+1}.{courses[i]}");
            }

        }

        private static void SwapCourses(List<string> courses, string lessonTitle, string secondLessonTitle)
        {
            int firstLessonIndex = courses.IndexOf(lessonTitle);
            int secondLessonIndex = courses.IndexOf(secondLessonTitle);

            string temp = secondLessonTitle;
            courses[secondLessonIndex] = lessonTitle;
            courses[firstLessonIndex] = temp;

            if (courses.Contains(lessonTitle + "-Exercise"))
            {
                courses.Remove(lessonTitle + "-Exercise");
                courses.Insert(secondLessonIndex + 1, lessonTitle + "-Exercise");
            }

            if (courses.Contains(secondLessonTitle + "-Exercise"))
            {
                courses.Remove(secondLessonTitle + "-Exercise");
                courses.Insert(firstLessonIndex + 1, secondLessonTitle + "-Exercise");
            }
        }
    }
}
