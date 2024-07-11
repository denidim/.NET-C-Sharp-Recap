namespace CustomListStackQueue
{
    internal class CustomStack<T>
    {
        /*void Push(int element) – Adds the given element to the stack
         int Pop() – Removes the last added element
         int Peek() – Returns the last element in the stack without removing it
         void ForEach(Action<int> action) – Goes through each of the elements in the stack

         int[] items - An array, which will hold all of our elements.
         int Count – This property will return the count of items in the collection.
         const int InitialCapacity – this constant's value will be the initial capacity of the internal array.*/

        private const int DefaultCapacity = 4;

        private T[] items;

        public CustomStack()
        {
            Count = 0;
            items = new T[DefaultCapacity];
        }

        public int Count { get; private set; }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }

        public void Push(T item)
        {
            Resize();
            items[Count] = item;
            Count++;
        }

        public T Pop()
        {
            if (Count < 1)
            {
                throw new InvalidOperationException();
            }
            return items[--Count];
        }

        public T Peek()
        {
            if (Count < 1)
            {
                throw new IndexOutOfRangeException();
            }
            return items[Count - 1];
        }

        private void Resize()
        {
            if (Count < items.Length)
            {
                return;
            }

            T[] newArray = new T[Count * 2];

            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }

            items = newArray;
        }
    }
}
