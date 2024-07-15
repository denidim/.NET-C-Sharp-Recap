namespace Library
{
    internal class Book
    {
        public Book(string title, int year, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public IEnumerable<string> Authors { get; set; }

        public override string ToString()
        {
            string authors = string.Empty;

            if (this.Authors.Count() == 0) 
            {
                authors = "Author: n/a";
            }
            else if(this.Authors.Count() == 1)
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
