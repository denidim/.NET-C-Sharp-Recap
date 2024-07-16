namespace ListyIteratorExercise
{
    internal class ListyIterator<T>
    {
        private List<T> collection = new List<T>();

        private int index = 0;

        public ListyIterator(params T[] collection)
        {
            this.collection = collection.ToList();
        }

        public bool Move() => ++index < this.collection.Count;

        public bool HasNext() => index + 1 < this.collection.Count;

        public void Print()
        {
            if (index < 0 && index >= this.collection.Count && collection.Count == 0)
            {
                throw new Exception("Invalid Operation!");
            }
            Console.WriteLine(collection[index]);
        }
    }
}
