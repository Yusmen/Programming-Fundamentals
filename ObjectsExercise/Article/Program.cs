using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article
{ 
    class Program
    {
        static void Main(string[] args)
        {

            List<Article> articles = new List<Article>();
            int n = int.Parse(Console.ReadLine());
            string[] symbols = { ", " };
            for (int i = 0; i < n; i++)
            {

                string[] input = Console.ReadLine().Split(symbols, StringSplitOptions.RemoveEmptyEntries);
                string title = input[0];
                string content = input[1];
                string author = input[2];
                Article article = new Article(title,content,author);
               
                articles.Add(article);


            }
            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
                articles=articles.OrderBy(x => x.Title).ToList();
            }
            else if (criteria == "content")
            {
               articles= articles.OrderBy(x => x.Content).ToList();
            }
            else if (criteria == "author")
            {
                articles=articles.OrderBy(x => x.Author).ToList();
            }
            Console.WriteLine(string.Join( Environment.NewLine,articles));
            
     
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
