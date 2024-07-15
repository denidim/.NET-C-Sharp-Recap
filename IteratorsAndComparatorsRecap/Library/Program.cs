namespace Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            BooksLibrary libraryOne = new BooksLibrary();

            BooksLibrary libraryTwo = new BooksLibrary(bookOne, bookTwo, bookThree);

            //foreach (Book item in libraryTwo)
            //{
            //    Console.WriteLine(item);
            //}

            var enumerator = libraryTwo.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Book item = enumerator.Current;
                Console.WriteLine(item);
            }
        }
    }
}
