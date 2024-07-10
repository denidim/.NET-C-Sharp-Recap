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
            _array[_indexer] = element;
            _indexer++;
            _count++;
        }

    }
}