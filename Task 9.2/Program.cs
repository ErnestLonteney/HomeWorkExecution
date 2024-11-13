namespace Task_9._2
{
    internal class Program
    {
        static void DisplayArray(byte[] array)
        {
            Console.WriteLine(new string('*', 20));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 20));
        }

        static byte GetMin(byte[] array)
        {
            byte min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }

            return min; 
        }

        static byte GetMax(byte[] array)
        {
            byte max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }

            return max;
        }

        static int GetSum(byte[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                sum += array[i];    
            }

            return sum;
        }

        static int GetAvarage(byte[] array)
        {
            var sum = GetSum(array);

            return sum / array.Length;  
        }

        static void DisplayPairedNumbers(byte[] array)
        {
            Console.WriteLine(new string('*', 20));

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine(new string('*', 20));
        }

        static void Main()
        {
            Console.WriteLine("Input size of array");
            string answer = Console.ReadLine();

            if (ushort.TryParse(answer, out ushort number))
            {
                var random = new Random();
                byte[] array = new byte[number];

                for (int i = 0; i < number; i++)
                {
                    array[i] = (byte)random.Next(1, 255);
                }

                Console.WriteLine("Genarated array");
                DisplayArray(array);
                Console.WriteLine("Payred numbers");
                DisplayPairedNumbers(array);
                var min = GetMin(array);
                Console.WriteLine($"Min value is {min}");
                var max = GetMax(array);
                Console.WriteLine($"Max value is {max}");
                var avarage = GetAvarage(array);
                Console.WriteLine($"Avarage value is {avarage}");
                var sum = GetSum(array);
                Console.WriteLine($"Sum of elements is {sum}");
            }
        }
    }
}
