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

    }
}
