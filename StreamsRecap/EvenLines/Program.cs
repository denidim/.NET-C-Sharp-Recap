using System.Text;

namespace EvenLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";
            
            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader streamReader = new StreamReader(inputFilePath);
            
            int counter = 0;

            using (streamReader)
            {
                while (true)
                {
                    string? line = streamReader.ReadLine();

                    if (counter % 2 == 0)
                    {
                        string replaced = ReplaceSymbols(line!);

                        string reversed = ReverseWords(replaced);

                        sb.AppendLine(reversed);
                    }

                    if (streamReader.EndOfStream)
                    {
                        break;
                    }
                    counter++;
                }
            }
            return sb.ToString().TrimEnd();
        }

        private static string ReverseWords(string replacedSymbols)
        {
            return string.Join(" " ,replacedSymbols.Split().Reverse());
        }

        private static string ReplaceSymbols(string line)
        {
            IEnumerable<char> chars = new List<char> { '-', ',', '.', '!', '?' };

            foreach (var item in chars)
            {
                if (line.Contains(item))
                {
                    line = line.Replace(item, '@');
                }
            }
            return line;
        }
    }
}
