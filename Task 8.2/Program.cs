namespace Task_8._6
{
    internal class Program
    {
        static void Calculate(int a, int b, int c, out double res1, out double res2, out double res3)
        {
            res1 = (double)a / 5;
            res2 = (double)b / 5;
            res3 = (double)c / 5;
        }

        static (double res1, double res2, double res3) GetCalculatedValues(int a, int b, int c) => 
               ((double)a / 5, 
                (double)b / 5, 
                (double)c / 5);

        static void Main()
        {
            Calculate(1, 2, 3, out double res1, out double res2, out double res3);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);

            Console.WriteLine(new String('-', 20));

            var result = GetCalculatedValues(1, 2, 3);
            Console.WriteLine(result.res1);
            Console.WriteLine(result.res2);
            Console.WriteLine(result.res3);   
        }
    }
}
