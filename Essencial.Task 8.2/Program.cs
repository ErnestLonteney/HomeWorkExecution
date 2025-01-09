namespace Essencial.Task_8._2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Input your message");
            string text = Console.ReadLine();
            
            Console.WriteLine("Choise color");
            Console.WriteLine("1-White");            
            Console.WriteLine("2-Yellow");
            Console.WriteLine("3-Green");
            Console.WriteLine("4-Blue");
            Console.WriteLine("5-Viollet");
            Console.WriteLine("6-Red");

            string answer = Console.ReadLine();

            Color color = (answer) switch
            {
                "1" => Color.White,
                "2" => Color.Yellow,
                "3" => Color.Green,
                "4" => Color.Blue,
                "5" => Color.Viollet,
                "6" => Color.Red,
                _ => Color.Gray
            };

            ConsolePrinter.Print(text, color);  
        }
    }
}
