using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorPattern
{
    public class Article : ArticleComponent
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public Article(string title, string content, string category, DateTime date, double price)
        {
            Title = title;
            Content = content;
            Category = category;
            Date = date;
            Price = price;
        }

        public override void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Date: {Date}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
