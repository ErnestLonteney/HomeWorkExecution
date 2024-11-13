using System.ComponentModel;

namespace Task_7._2
{
    internal class Program
    {
        static double Add(double x, double y)   
        { 
            return x + y; 
        }

        static double Sub(double a, double b)
        {
            return a - b;   
        }

        static double Mul(double a, double b)
        {
            return (a * b);
        }

        static double Pow(double a, double b)
        {
            return (double)Math.Pow(a, b);
        }

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
            Console.WriteLine("Input A");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Input B");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Input sigh (+, -, *, /, #)");
            var sign = Console.ReadLine();

            double result = 0;
            bool isErrorOccuurred = false;

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
                    result = Div(a, b, out isErrorOccuurred);
                    break;
                case "#":
                    result = Pow(a, b);
                    break;
                default:
                    Console.WriteLine("You have inputed unrecognized comman");
                    break;
            }

            if (isErrorOccuurred)
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
