namespace Essencial.Task_1._2
{
    internal class Program
    {
        static void Main()
        {
            var rec1 = new Rectangle(23, 45);

             
            Console.WriteLine($"Area of rectangle = {rec1.Area}");
            Console.WriteLine($"Perimetr of rectangle = {rec1.Perimetr}");

            var rec2 = new Rectangle(25, 44);

            Console.WriteLine($"Area of rectangle = {rec2.Area}");
            Console.WriteLine($"Perimetr of rectangle = {rec2.Perimetr}");
        }
    }
}
