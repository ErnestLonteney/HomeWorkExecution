namespace Essencial.Task_6._4
{
    static class ArrayExtantions
    {
        public static void BubbleSort(this int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var buf = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = buf; 
                    }
                }
            }
        }
    }
}
