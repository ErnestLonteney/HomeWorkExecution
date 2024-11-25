namespace TryParseVsParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            string answer = Console.ReadLine();

            int result = 0;
            var tryResult = int.TryParse(answer, out result);

            Console.WriteLine(result);  
        }
    }
}
