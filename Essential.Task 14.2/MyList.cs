using System.Collections;

namespace Essential.Task_14._2
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>    
    {
        private T[] elements;
        private int currentPossition = 0;
        private int position = -1;

        public MyList()
        {
            elements = new T[10];
        }

        public MyList(IEnumerable<T> elements)
        {
            this.elements = new T[elements.Count() * 2];

            int i = 0;
            foreach (T element in elements)
            {
                this.elements[i++] = element;
            }

            currentPossition = elements.Count();
        }

        public void Add(T newElement)
        {
            if (currentPossition == elements.Length / 2)
            {
                ResizeInnerArray();             
            }

            elements[currentPossition++] = newElement;
        }

        public int Count => elements.Length;

        private void ResizeInnerArray()
        {
            var newArray = new T[elements.Length * 2];
            Array.Copy(elements, newArray, elements.Length);
            this.elements = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public void Reset() => position = -1;

        public T Current => elements[position];

        object IEnumerator.Current => elements[position];

        public bool MoveNext()
        {
            if (position != currentPossition - 1)
            {
                position++; 
                return true;
            }

            return false;
        }

        public void Dispose()
        {
            Reset();
        }

        public T this[int index]
        {
            get 
            {
                if (index >=0 && index < elements.Length)
                    return elements[index];

                return default;
            }
        }
    }
}
