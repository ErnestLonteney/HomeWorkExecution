namespace Essential.Task_15._5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input a");
            var answer = Console.ReadLine();
            var aResult = Double.TryParse(answer, out double a);

            Console.WriteLine("Input operation (+, -, /, *, Pif, ~)");
            var sign = Console.ReadLine();

            Console.WriteLine("Input b");
            answer = Console.ReadLine();    
            var bResult = Double.TryParse(answer, out double b);

            if (aResult && bResult)
            {
                
                var result = 0.0;
                string? message = null;

                switch (sign)
                {
                    case "+": result = Calculator.Add(a, b);
                        break;
                    case "-":
                        result = Calculator.Sub(a, b);
                       break;
                    case "*":
                        result = Calculator.Mul(a, b);
                        break;
                    case "/":
                        try
                        {
                            result = Calculator.Div(a, b);
                        }
                        catch (DivideByZeroException ex) 
                        {
                           message = ex.Message;
                        }
                        break;
                 case "Pif": result = Calculator.Calculate(a, b, (a, b) => Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)), out message);
                        break;
                    case "~": result = Calculator.Calculate(a, b, (a, b) => (a + b) / 0, out message);
                        break;
                    default:
                        Console.WriteLine("Not valid operation");
                        break;
                }

                if (message is not null)
                {
                    Console.WriteLine($"Error has been occurred with such message '{message}'");
                }
                else
                {
                    Console.WriteLine($"Result {result:##.##}");
                }
            }
        }
    }
}
