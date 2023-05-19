using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorPattern
{
    public class FeaturedArticle : ArticleDecorator
    {
        public bool IsFeatured { get; set; }

        public FeaturedArticle(ArticleComponent articleComponent) : base(articleComponent)
        {
            IsFeatured = true;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"IsFeatured: {IsFeatured}");
        }
    }
}
