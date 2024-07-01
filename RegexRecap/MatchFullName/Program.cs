using System.Text.RegularExpressions;

namespace MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            Regex regex = new Regex(pattern);

            string names = Console.ReadLine()!;

            MatchCollection matches = regex.Matches(names);

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
