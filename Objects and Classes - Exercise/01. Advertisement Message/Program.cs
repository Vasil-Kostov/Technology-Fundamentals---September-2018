namespace _01._Advertisement_Message
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            int numberOfAdvertises = int.Parse(Console.ReadLine());

            Advertise advertise = new Advertise();

            for (int i = 0; i < numberOfAdvertises; i++)
            {
                Console.WriteLine(advertise.GenerateNewRandomAdvertise());
            }
            
        }
    }

    class Advertise
    {
        public List<string> Phrases { get; } = new List<string>()
        {
            "Excellent product.", "Such a great product.", "I always use that product.",
             "Best product of its category.", "Exceptional product.", "I can’t live without this product."
        };
        public List<string> Events { get; } = new List<string>()
        {
            "Now I feel good.", "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.", "I feel great!"
        };

        public List<string> Authors { get; } = new List<string>()
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
        };

        public List<string> Cities { get; } = new List<string>
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };
        
        public string GenerateNewRandomAdvertise()
        {
            string advertise = string.Empty;

            Random random = new Random();

            advertise += $"{this.Phrases[random.Next(this.Phrases.Count)]} ";
            advertise += $"{this.Events[random.Next(this.Events.Count)]} ";
            advertise += $"{this.Authors[random.Next(this.Authors.Count)]} - "; 
            advertise += $"{this.Cities[random.Next(this.Phrases.Count)]}.";
            
            return advertise;
        }

    }
}
