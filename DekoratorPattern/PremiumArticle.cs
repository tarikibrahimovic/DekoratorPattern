using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorPattern
{
    public class PremiumArticle : ArticleDecorator
    {
        public bool IsPremium { get; set; }

        public PremiumArticle(ArticleComponent articleComponent) : base(articleComponent)
        {
            IsPremium = true;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine($"IsPremium: {IsPremium}");
        }
    }
}
