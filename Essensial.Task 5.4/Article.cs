namespace Essensial.Task_5._4
{
    class Article
    {
        public string Name { get; init; }
        public string Producer { get; set; }
        public double Price { get; set; }

        public Article(string name, string producer)
        {
            this.Name = name;
            this.Producer = producer;
        }

        public Article()
        {
                
        }
    }
}
