namespace Task_6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input A");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input B");
            var b = Convert.ToInt32(Console.ReadLine());



           // if (a < b)
            {
                int sum = 0;
                //a++;

                //while (a < b)
                //{
      
                //   sum += a;

                //    if (a % 2 != 0)
                //        Console.WriteLine(a);

                //    a++;
                //}

                do
                {
                    sum += a;

                    if (a % 2 != 0)
                        Console.WriteLine(a);

                    a++;
                }
                while (a < b);

                for (int index = --b; index > a; index--)
                {
                    sum += index;

                    if (index % 2 != 0)
                        Console.WriteLine(index);
                }

                Console.WriteLine($"Sum is {sum}");
            }
        }
    }
}
