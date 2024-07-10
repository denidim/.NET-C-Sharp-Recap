namespace CustomListStackQueue
{
    internal class CustomList
    {
        /*void Add(int element) - Adds the given element to the end of the list
          int RemoveAt(int index) - Removes the element at the given index
          bool Contains(int element) - Checks if the list contains the given element returns (True or False)
          void Swap(int firstIndex, int secondIndex) - Swaps the elements at the given indexes*/

        private int[] _array = new int[2];

        private int _indexer = 0;

        private int _count = 0;

        public int Count => this._count;

        public void Add(int element)
        {
            if (this._count == this._array.Length)
            {
                Resize();
            }

            _array[_indexer] = element;
            _indexer++;
            _count++;
        }

        private void Resize()
        {
            var old = this._array;

            this._array = new int[_array.Length * 2];

            for (int i = 0; i < old.Length; i++)
            {
                this._array[i] = old[i];
            }
        }

        //public int RemoveAt(int index)
        //{
        //    int removed;
        //    if (this._count >= index)
        //    {
        //        throw new IndexOutOfRangeException();
        //    }
        //    else
        //    {
        //        removed = _array[_indexer];

        //        for (int i = _indexer; i < removed; i++)
        //        {
        //            int next = _array[i];
        //        }
        //    }

        //    return 0;
        //}
    }
}