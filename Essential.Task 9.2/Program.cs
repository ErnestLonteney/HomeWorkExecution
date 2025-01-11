namespace Essential.Task_9._2
{
    internal class Program
    {
        static void Main()
        {
            Calculate add = (double a, double b, out string calculationMessage) =>
            {
                calculationMessage = string.Empty;
                return a + b;
            };

            Calculate sub = (double a, double b, out string calculationMessage) =>
            {
                calculationMessage = string.Empty;
                return a - b;
            };

            Calculate mul = (double a, double b, out string calculationMessage) =>
            {
                calculationMessage = string.Empty;
                return a * b;
            };

            Calculate div = (double a, double b, out string calculationMessage) =>
            {
                if (b != 0)
                {
                    calculationMessage = string.Empty;
                    return a / b;
                }

                calculationMessage = "Try dividing by zero";
                return 0;
            };

            Console.WriteLine("Input a");
            string answerA = Console.ReadLine();
            Console.WriteLine("Input b");
            string answerB = Console.ReadLine();

            if (double.TryParse(answerA, out double a)
            && double.TryParse(answerB, out double b))
            {
                string message = string.Empty;
                double result;

                result = Calculator.Calculate(a, b, add, out message);
                Console.WriteLine($"{a} + {b} = {result}");

                result = Calculator.Calculate(a, b, sub, out message);
                Console.WriteLine($"{a} - {b} = {result}");

                result = Calculator.Calculate(a, b, mul, out message);
                Console.WriteLine($"{a} * {b} = {result}");

                result = Calculator.Calculate(a, b, div, out message);
                if (string.IsNullOrEmpty(message))
                {
                    Console.WriteLine($"{a} / {b} = {result}");
                }
                else
                {
                    Console.WriteLine($"Error has occured with message - {message}");
                }
            }
        }
    }
}
