namespace Task_3._3
{
    internal class Program
    {
        static void Main()
        {
            const float PI = 3.141f;
            Console.WriteLine("Input radius, please");
            var radius = float.Parse(Console.ReadLine());

            var result = PI * Math.Pow(radius, 2);

            Console.WriteLine($"Area of circle is {result:##.##}");        
            Console.ReadKey();
        }
    }
}
