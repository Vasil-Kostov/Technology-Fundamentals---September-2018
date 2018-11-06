namespace _02._Articles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Article article = new Article(Console.ReadLine().Split(", "));

            int numberOfOverrides = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfOverrides; i++)
            {
                string[] inputArr = Console.ReadLine().Split(": ");

                switch (inputArr[0])
                {
                    case "Edit":
                        article.EditContent(inputArr[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(inputArr[1]);
                        break;
                    case "Rename":
                        article.RenameTitle(inputArr[1]);
                        break;
                    case "ToString":
                        Console.WriteLine(article.ToString());
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(article.ToString());
            
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

        public void EditContent(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void RenameTitle(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
