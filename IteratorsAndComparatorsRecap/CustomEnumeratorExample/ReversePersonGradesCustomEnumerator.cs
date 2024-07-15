using System.Collections;

namespace CustomEnumeratorExample
{
    internal class ReversePersonGradesCustomEnumerator : IEnumerator<int>
    {
        private int index;

        private int[] items;

        public ReversePersonGradesCustomEnumerator(int[] items)
        {
            this.items = items;
            index = items.Length;
        }

        public int Current => items[index];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            index--;

            if (index < 0)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        // legacy
        object IEnumerator.Current => this.Current;
    }
}