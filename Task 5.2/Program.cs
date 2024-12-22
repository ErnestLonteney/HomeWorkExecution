namespace Task_5._2
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Input number");
            string answer = Console.ReadLine();

            if (int.TryParse(answer, out int n))
            {
                if (n != 0)
                {
                    if ((n % 2) == 0)
                    {
                        Console.WriteLine("The number is paired");
                    }
                    else
                    {
                        Console.WriteLine("Not paired number");
                    }

                    if ((n & 1) == 0)
                    {
                        Console.WriteLine("The number is paired");
                    }
                    else
                    {
                        Console.WriteLine("Not paired number");
                    }
                }
                else
                {
                    Console.WriteLine("Zero cannot be paired or unpaired");
                }
            }         
        }
    }
}
