namespace Task_5._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input A");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input B");
            var b = Convert.ToInt32(Console.ReadLine());

            int res1 = a | b;
            int res2 = ~(~a & ~b);

            Console.WriteLine((res1 == res2) ? "Succesful" : "Unsuccesful");
        }
    }
}
