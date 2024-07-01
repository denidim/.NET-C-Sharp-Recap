using System.Text;

namespace PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = from; i <= to; i++)
            {
                sb.Append($"{(char)i} ");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}