namespace Essensial.Task_5._4
{
    class Store
    {
        private readonly Article[] articles;

        public Store(params Article[] articles)
        {
            this.articles = articles; 
        }

        public Article this[int index]
        {
            get 
            {
                if (index >= 0 && index < articles.Length)
                {
                    return articles[index];
                }

                return null;
            }
        }


        public Article this[string name]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].Name.ToUpper() == name.ToUpper())
                        return articles[i];
                }

                return null;
            }
        }
    }
}
