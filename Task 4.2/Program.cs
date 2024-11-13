namespace HomwWorkExecution
{
    internal class Program
    {
        static void Main()
        {
            double operand1, operand2, result = 0;
            Console.WriteLine("Please, input operand1");
            operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please, input operand2");
            operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input operation (+, -, *, /, %)");

            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+": 
                    result = operand1 + operand2; 
                    break;
                case "-":
                    result = operand1 - operand2;
                    break;
                case "*":
                    result = operand1 * operand2;
                    break;
                case "/":
                    if (operand2 != 0)
                    {
                        result = operand1 / operand2;
                    }
                    else
                    {
                        Console.WriteLine("Try dividing by zero");
                    }
                    break;
                case "%":
                    result = operand1 % operand2;
                    break;
            }

            Console.WriteLine($"The result is {result}");

        }
    }
}
