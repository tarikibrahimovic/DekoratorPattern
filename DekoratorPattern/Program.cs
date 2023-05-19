using DekoratorPattern;

Article article1 = new Article("Naslov 1", "Sadržaj 1", "Kategorija 1", DateTime.Now, 100);
FeaturedArticle featuredArticle1 = new FeaturedArticle(article1);
PremiumArticle premiumArticle1 = new PremiumArticle(featuredArticle1);

premiumArticle1.Display();
featuredArticle1.Display();