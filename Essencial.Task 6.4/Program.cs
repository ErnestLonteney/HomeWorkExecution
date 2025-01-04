namespace Essencial.Task_6._4
{
    internal class Program
    {
        static void Main()
        {
            int[] array = [23, 45, 12, 23, 78, 0];

            array.BubbleSort(); 

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);    
            }
        }
    }
}
