using System;
using System.Collections.Generic;

namespace Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> list = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] sentance = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Article newSentance = new Article(sentance[0], sentance[1], sentance[2]);
                list.Add(newSentance);
            }

            string r = Console.ReadLine();

            foreach (Article sentance in list)
            {
                Console.WriteLine($"{sentance.Title} - {sentance.Content}: {sentance.Author}");
            }
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
    }
}
