namespace Task_5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years have you been working?");
            var res = Convert.ToByte(Console.ReadLine());
            byte addingProcent;

            if (res <= 5)
            {
                addingProcent = 10;
            }
            else
            if (res <= 10)
            {
                addingProcent = 15;
            }
            else
            if (res <= 15)
            {
                addingProcent = 25;
            }
            else
            if (res <= 20)
            {
                addingProcent = 35;
            }
            else
            if (res <= 25)
            {
                addingProcent = 45;
            }
            else
            {
                addingProcent = 50;
            }

            Console.WriteLine($"Adding to salary is {addingProcent}%");

            byte result = (res) switch
            {
                <= 5 => 10,
                <= 10 => 15,
                <= 15 => 25,
                <= 20 => 35,
                <= 25 => 45,
                _ => 50
            };

            //Console.WriteLine($"Adding to salary is {result}%");
        }
    }
}
