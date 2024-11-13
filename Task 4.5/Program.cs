using System.Text;

namespace Task4._5
{
    internal class Program
    {
        static string Translate(string word)
        {
            return
            word.ToLower() switch
            {
                "яблуко" => "Apple",
                "груша" => "Pear",
                _ => "Unknown word"
            };
        }


        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Input word in ukrainian");

            string word = Console.ReadLine();
            string translate = Translate(word);

            Console.WriteLine(translate);   
        }
    }
}
