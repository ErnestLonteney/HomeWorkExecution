namespace Essential.Task_15._5
{
    delegate double Calculate(double a, double b);
    static class Calculator
    {
        public static List<double> ResultsHistory { get; } = [];

        public static double Add(double a, double b)
        {
           var result = a + b;
           ResultsHistory.Add(result);
           
           return result;
        }
        public static double Sub(double a, double b)
        {
            var result = a - b;
            ResultsHistory.Add(result);
            
            return result;
        }
        public static double Mul(double a, double b)
        {
           var result = a * b;
           ResultsHistory.Add(result);
            
           return result;
        }

        public static double Div(double a, double b)  
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Critical error - Cannot divide by zero!");
            }

            var result = a / b;
            ResultsHistory.Add(result);
            
            return result;  
        }

        public static double Calculate(double a, double b, Calculate method, out string? message)
        {
            message = null;

            try
            {
                var result = method.Invoke(a, b);
                ResultsHistory.Add(result);

                return result;
            }
            catch (Exception e)
            {
                message = GetInnerMessage(e);

                return -1;
            }
        }

        private static string GetInnerMessage(Exception exception)
        {
            if (exception.InnerException != null)
            {
                return GetInnerMessage(exception.InnerException);  
            }

            return exception.Message;
        }
       
    }
}
