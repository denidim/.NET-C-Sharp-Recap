namespace Library
{
    internal class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public string Title { get; private set; }

        public int Year { get; private set; }

        public IReadOnlyCollection<string> Authors { get; private set; }

        public int CompareTo(Book? other)
        {
            int result = this.Title.CompareTo(other.Title);


            if (result == 0)
            {
                result = this.Year.CompareTo(other.Year);
            }

            return result;
        }

        public override string ToString()
        {
            string authors = string.Empty;

            if (this.Authors.Count() == 0)
            {
                authors = "Author: n/a";
            }
            else if (this.Authors.Count() == 1)
            {
                authors = $"Author: {this.Authors.First()}";
            }
            else
            {
                authors = $"Author: {string.Join("\n\rAuthor: ", this.Authors)}";
            }
            return $"Title: {this.Title} Year: {this.Year}\n\r{authors}";
        }
    }
}
