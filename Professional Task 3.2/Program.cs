namespace Professional_Task_3._2
{
    internal class Program
    {
        static void Main()
        {
            FileStream stream = File.Create("somefile2.dat");

            byte[] numbers = [12, 34, 56, 255, 0, 10];

            foreach (byte number in numbers)
            {
                stream.WriteByte(number);
            }

            stream.Close();

            FileStream readFile = File.OpenRead("somefile2.dat");
            int res;
            while ((res = readFile.ReadByte()) != -1) 
            {
               Console.Write($"{res} ");
            }
           
            readFile.Close();

        }
    }
}
