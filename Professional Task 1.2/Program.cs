namespace Professional_Task_1._2
{
    internal class Program
    {
        static void Main()
        {
            var monthes = new MounthCollection();

            foreach (Month month in monthes)
            {
                Console.WriteLine(month.Name);
            }

            Console.WriteLine(monthes[3].Name);

            Console.WriteLine(new string('-', 50));

            foreach (Month month in monthes["30"])
            {
                Console.WriteLine(month.Name);  
            }
        }
    }
}
