using System.Text;

namespace LineNumbers
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //using (var sr = new StreamReader("input.txt"))
            //{
            //    string? line = await sr.ReadLineAsync();

            //    using (var writer = new StreamWriter("../../../Output.txt"))
            //    {
            //        int counter = 1;

            //        while (line != null)
            //        {
            //            await writer.WriteLineAsync($"{counter}. {line}");

            //            counter++;        
            //            line = await sr.ReadLineAsync();
            //        }
            //    }
            //}

            string inputFilePath = "../../../Input.txt";
            string outputFilePath = "../../../Output.txt";
            await ProcessLines(inputFilePath, outputFilePath);

        }

        public static async Task ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = await File.ReadAllLinesAsync(inputFilePath);
            string processedLines = InsertAndCount(lines);
            await File.WriteAllTextAsync(outputFilePath,processedLines);
        }

        private static string InsertAndCount(string[] lines)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = lines[i].Count(x => Char.IsLetter(x));
                int punctuationsCount = lines[i].Count(x => Char.IsPunctuation(x));

                sb.AppendLine($"Line {i + 1}: - {lines[i]} ({lettersCount})({punctuationsCount})");
            }

            return sb.ToString();
        }
    }
}
