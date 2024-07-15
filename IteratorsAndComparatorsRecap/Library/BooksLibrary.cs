using System.Collections;

namespace Library
{
    internal class BooksLibrary : IEnumerable<Book>
    {
        private readonly IEnumerable<Book> books;

        public BooksLibrary(params Book[] books)
        {
            this.books = new SortedSet<Book>(books, new BookComparator());
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
