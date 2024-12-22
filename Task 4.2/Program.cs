namespace HomwWorkExecution
{
    internal class Program
    {
        static void Main()
        {
            bool hasResult = false;
            double operand1, operand2, result = 0;
            Console.WriteLine("Please, input operand1");

            if (double.TryParse(Console.ReadLine(), out operand1))
            {
                Console.WriteLine("Please, input operand2");
                if (double.TryParse(Console.ReadLine(), out operand2))
                {
                    Console.WriteLine("Please input operation (+, -, *, /, %)");

                    string sign = Console.ReadLine();
                    hasResult = true;

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
                                hasResult = false;
                            }
                            break;
                        case "%":
                            if (operand2 != 0)
                            {
                                result = operand1 % operand2;
                            }
                            else
                            {
                                Console.WriteLine("Try dividing by zero");
                                hasResult = false;
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Wrong sign");
                                hasResult = false;
                                break;
                            }
                    }                
                }             
            }

            if (!hasResult)
            {
                Console.WriteLine("Something went wrong");
            }
            else
            {
                Console.WriteLine($"The result is {result}");
            }
        }
    }
}
