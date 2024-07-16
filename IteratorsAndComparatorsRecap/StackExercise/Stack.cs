using System.Collections;

namespace StackExercise
{
    internal class Stack<T> : IEnumerable<T>
    {
        private readonly List<T> elements;

        public Stack(params T[] elements)
        {
            this.elements = elements.ToList();
        }

        public void Push(params T[] elements)
        {
            foreach (var item in elements)
            {
                this.elements.Add(item);
            }
        }

        public T Pop()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("No elements");
            }

            var element = this.elements[this.elements.Count - 1];

            this.elements.RemoveAt(this.elements.Count - 1);

            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.elements.Count-1; i >= 0; i--)
            {
                yield return this.elements[i];
            }

            for (int i = this.elements.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
