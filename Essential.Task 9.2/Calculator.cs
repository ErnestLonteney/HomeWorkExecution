namespace Essential.Task_9._2
{
    static class Calculator
    {
        public static double Calculate(double a, double b, Calculate calculate, out string error)
        {
           var result =  calculate.Invoke(a, b, out error);
            



           return result;
        }
    }
}
