namespace RandomList
{
    internal class MyList<T> : List<T>
    {
        private Random random = new Random();

        public T GetRandom()
        {
            var index = random.Next(0, base.Count);

            return base[index];
        }

        public T RemoveRandom()
        {
            T element;
            var index = random.Next(0, base.Count);
            element = base[index];
            RemoveAt(index);
            return element;
        }
    }
}
