using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Froggy
{
    internal class Lake : IEnumerable<int>
    {
        private readonly List<int> stones;

        public Lake(params int[] stones)
        {
            this.stones = stones.ToList();
        }

        public IEnumerator<int> GetEnumerator()
        {
            /* First, the frog must jump on all the stones, which are in even positions in ascending order,
             * and then on all the odd ones, but in reversed order*/

            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    yield return stones[i];
                }
            }

            for (int i = stones.Count - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
