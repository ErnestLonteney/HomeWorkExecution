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

            ConsoleColor color = (answer) switch
            {
                "1" => ConsoleColor.White,
                "2" => ConsoleColor.Yellow,
                "3" => ConsoleColor.Green,
                "4" => ConsoleColor.Blue,
                "5" => ConsoleColor.DarkBlue,
                "6" => ConsoleColor.Red,
                _ => ConsoleColor.Gray
            };

            ConsolePrinter.Print(text, color);  
        }
    }
}
