namespace Essensial.Task_5._4
{
    internal class Program
    {
        static void Main()
        {
            var mouse = new Article
            {
                Name = "Optic Mouse",
                Producer = "Microsoft",
                Price = 135.56
            };

            var monitor = new Article("LG monitor", "LG Electronics")
            {
                Price = 1234.56
            };

            var laptop = new Article
            {
                Name = "Laptop",
                Producer = "Samsung",
                Price = 134.56
            };


            var store = new Store(mouse, monitor, laptop);

            while (true)
            {
                Article article = null;

                Console.WriteLine("Input index or name");
                string answer = Console.ReadLine();

                if (int.TryParse(answer, out int index))
                {
                    article = store[index];
                }
                else
                {
                    article = store[answer];
                }

                if (article != null)
                {
                    Console.WriteLine(new string('-', 50));
                    Console.WriteLine(article.Name);
                    Console.WriteLine(article.Producer);
                    Console.WriteLine($"{article.Price:C}");
                    Console.WriteLine(new string('-', 50));
                }
                else
                {
                    Console.WriteLine("Artical has not been found");
                }
            }
        }
    }
}
