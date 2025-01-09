

namespace Essencial.Task_8._2
{
    static class ConsolePrinter
    {
        public static void Print(string text, Color color)
        {
            Console.ForegroundColor = (color) switch
            {
                Color.Blue => ConsoleColor.Blue,
                Color.Viollet => ConsoleColor.DarkBlue,
                Color.White => ConsoleColor.White,
                Color.Yellow => ConsoleColor.Yellow,
                Color.Green => ConsoleColor.Green,
                Color.Gray => ConsoleColor.Gray
            };

            Console.WriteLine(text);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
