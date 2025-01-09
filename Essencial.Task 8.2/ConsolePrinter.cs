

namespace Essencial.Task_8._2
{
    static class ConsolePrinter
    {
        public static void Print(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(text);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
