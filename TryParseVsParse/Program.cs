namespace TryParseVsParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 5;
            int x = 0;
            bool isValid = true;

            if (!((x > a && x < b) || isValid))
            {
                Console.WriteLine("We are here");
            }
        }
    }
}
