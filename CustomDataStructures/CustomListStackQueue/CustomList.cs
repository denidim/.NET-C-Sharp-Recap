namespace CustomListStackQueue
{
    internal class CustomList
    {
        /*      void Add(int element) - Adds the given element to the end of the list
                int RemoveAt(int index) - Removes the element at the given index
                bool Contains(int element) - Checks if the list contains the given element returns (True or False)
                void Swap(int firstIndex, int secondIndex) - Swaps the elements at the given indexes
                Resize – this method will be used to increase the internal collection's length twice
                Shrink – this method will help us to decrease the internal collection's length twice
                Shift – this method will help us to rearrange the internal collection's elements after removing one.*/

        private int[] _array = new int[2];

        private int _indexer = -1;

        private int _count = 0;

        public int this[int i]
        {
            get
            {
                IsInRange(i);

                return _array[i];
            }
            set
            {
                IsInRange(i);

                _array[i] = value;
            }
        }

        public int Count => this._count;

        public void Swap(int firstIndex, int secondIndex)
        {
            IsInRange(firstIndex);
            IsInRange(secondIndex);

            (this._array[secondIndex], this._array[firstIndex]) = (this._array[firstIndex], this._array[secondIndex]);
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (element == this._array[i])
                {
                    return true;
                }
            }
            return false;
        }

        public void Add(int element)
        {
            if (this._count == this._array.Length)
            {
                Resize();
            }
            _array[++_indexer] = element;
            _count++;
        }

        public int RemoveAt(int index)
        {
            IsInRange(index);

            int removed = _array[index];

            Shift(index);

            if (this._array.Length / this._count == 2 && this._count > 1)
            {
                Shrink();
            }

            return removed;
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

        private void Shift(int index)
        {
            this._count--;
            this._indexer--;

            for (int i = index; i < this._count; i++)
            {
                this._array[i] = this._array[i + 1];
            }
        }

        private void Shrink()
        {
            var old = this._array;
            this._array = new int[this._array.Length / 2];

            for (int i = 0; i < this._array.Length; i++)
            {
                this._array[i] = old[i];
            }
        }

        private void IsInRange(int i)
        {
            if (i < 0 || i >= this._count)
            {
                throw new IndexOutOfRangeException();
            }
        }
    }
}