using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DekoratorPattern
{
    public abstract class ArticleDecorator : ArticleComponent
    {
        protected ArticleComponent articleComponent;

        public ArticleDecorator(ArticleComponent articleComponent)
        {
            this.articleComponent = articleComponent;
        }

        public override void Display()
        {
            articleComponent.Display();
        }
    }
}
