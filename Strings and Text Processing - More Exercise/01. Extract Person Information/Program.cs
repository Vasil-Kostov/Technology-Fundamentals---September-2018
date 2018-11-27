namespace _01._Extract_Person_Information
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Tuple<string, int>> personalInfo = new List<Tuple<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                int startIndexOfName = input.IndexOf("@") + 1;
                int lengthOfName = input.IndexOf("|") - startIndexOfName;

                int startIndexOfAge = input.IndexOf("#") + 1;
                int lengthOfAge = input.IndexOf("*") - startIndexOfAge;

                string name = input.Substring(startIndexOfName, lengthOfName);
                int age = int.Parse(input.Substring(startIndexOfAge, lengthOfAge));

                Tuple<string, int> pereson = new Tuple<string, int>(name, age);

                personalInfo.Add(pereson);
            }

            foreach (var person in personalInfo)
            {
                Console.WriteLine($"{person.Item1} is {person.Item2} years old.");
            }

        }
    }
}
