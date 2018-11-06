namespace _03._Articles_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Article> articles = new List<Article>();
            
            int numberOfOverrides = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOverrides; i++)
            {
                articles.Add(new Article(Console.ReadLine().Split(", ")));
            }

            string orderBy = Console.ReadLine();

            switch (orderBy)
            {
                case "title":
                    Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(a => a.Title)));
                    break;
                case "content":
                    Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(a => a.Content)));
                    break;
                case "author":
                    Console.WriteLine(string.Join(Environment.NewLine, articles.OrderBy(a => a.Author)));
                    break;
                default:
                    break;
            }

        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string[] articleInfo)
        {
            this.Title = articleInfo[0];
            this.Content = articleInfo[1];
            this.Author = articleInfo[2];
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}