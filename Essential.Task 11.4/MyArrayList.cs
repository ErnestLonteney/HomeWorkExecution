namespace Essential.Task_11._4
{
    class MyArrayList<T>
    {
        private T[] array;
        private int currentIndex = 0;

        public MyArrayList()
        {
            array = new T[10];   
        }

        public object this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];

                return null;
            }
        }

        public void Add(T item)
        {
            if (currentIndex == array.Length / 2)
                ResizeArray();

            array[currentIndex++] = item;
        }

        public int Count() => currentIndex;    

        private void ResizeArray()
        {
            throw new NotImplementedException();
        }
    }
}
