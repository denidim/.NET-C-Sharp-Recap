using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359([\s|-])2\1\d{3}\1\d{4}";

            var match = Regex.Matches(Console.ReadLine()!, pattern);

            Console.WriteLine(string.Join(", ",match));
        }
    }
}
