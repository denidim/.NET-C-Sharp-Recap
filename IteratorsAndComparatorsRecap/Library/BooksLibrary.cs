using System.Collections;

namespace Library
{
    internal class BooksLibrary : IEnumerable<Book>
    {
        private readonly IEnumerable<Book> books;

        public BooksLibrary(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}
