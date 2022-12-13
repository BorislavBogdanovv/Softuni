using System;

namespace Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentance = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Edit")
                {
                    sentance[1] = command[1];
                }
                else if (command[0] == "ChangeAuthor")
                {
                    sentance[2] = command[1];
                }
                else if (command[0] == "Rename")
                {
                    sentance[0] = command[1];
                }
            }

            Article newSentance = new Article(sentance[0], sentance[1], sentance[2]);

            Console.WriteLine($"{newSentance.Title} - {newSentance.Content}: {newSentance.Author}");
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
