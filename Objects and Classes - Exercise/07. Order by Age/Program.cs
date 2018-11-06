namespace _07._Order_by_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                people.Add(new Person(input.Split()));

                input = Console.ReadLine();
            }

            foreach (var person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public Person(string[] personInfo)
        {
            this.Name = personInfo[0];
            this.ID = personInfo[1];
            this.Age = int.Parse(personInfo[2]);
        }
    }
}
