using System.ComponentModel;

namespace Task_7._2
{
    internal class Program
    {
        static double Add(double x, double y) => x + y; 
        
        static double Sub(double a, double b) => a - b;

        static double Mul(double a, double b) => a * b;

        static double Pow(double a, double b) => (double)Math.Pow(a, b);

        static double Div(double a, double b, out bool tryZeroDividing)
        {
            if (b == 0)
            {
                tryZeroDividing = true;
                return 0;
            }

            tryZeroDividing = false;
            return a / b;
        }

        static void Main()
        {
            Console.WriteLine(res.a);
            Console.WriteLine(res.b);

            Console.WriteLine("Input A");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input B");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input sigh (+, -, *, /, #)");
            var sign = Console.ReadLine();

            double result = 0;
            bool isErrorOccured = false;

            switch (sign)
            {
                case "+":
                    result = Add(a, b);
                    break;
                case "-":
                    result = Sub(a, b);
                    break;
                case "*":
                   result = Mul(a, b);
                   break;
                case "/":
                    result = Div(a, b, out isErrorOccured);
                    break;
                case "#":
                    result = Pow(a, b);
                    break;
                default:
                    Console.WriteLine("You have inputed unrecognized command");
                    break;
            }

            if (isErrorOccured)
            {
                Console.WriteLine("Unfortunatelly, error has been occured");
            }
            else
            {
                Console.WriteLine($"Result is {result}");
            }  
        }
    }
}
