
using System.Collections;

namespace Library
{
    internal class LibraryIterator : IEnumerator<Book>
    {
        private int index;
        private readonly Book[] books;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.index = -1;
            this.books = books.ToArray();
        }

        public Book Current => this.books[index];

        public bool MoveNext() => ++index < this.books.Length;

        public void Dispose() { }

        public void Reset() { }

        object IEnumerator.Current => this.Current;
    }
}