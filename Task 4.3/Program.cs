namespace Task_4._3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Input nuber from 1 to 100");
            string answer = Console.ReadLine();
            byte number = Convert.ToByte(answer);

            if (number >= 0 && number <= 100)
            {
                string res;

                if (number >= 51)
                {
                    res = "[51..100]";
                }
                else
                if (number >= 36)
                {
                    res = "[36..50]";
                }
                else
                if (number >= 15)
                {
                    res = "[15..35]";
                }
                else
                {
                    res = "[0..14]";
                }

                Console.WriteLine($"Range is {res}");

                string result = (number) switch
                {
                    >= 51 => "[51..100]",
                    >= 36 => "[36..50]",
                    >= 15 => "[15..35]",
                    _ => "[0..14]",
                };

                Console.WriteLine($"Range is {result}");
            }
            else
            {
                Console.WriteLine("The number is not in range");
            }
        }
    }
}
