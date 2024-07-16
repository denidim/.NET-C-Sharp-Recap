using System.Collections;

namespace Froggy
{
    internal class Lake : IEnumerable<int>
    {
        private readonly List<int> stones;

        public Lake(params int[] stones )
        {
            this.stones = stones.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
