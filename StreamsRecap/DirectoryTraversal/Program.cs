using System.Text;

namespace DirectoryTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine()!;

            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);

            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string path)
        {
            var filesInfo = new Dictionary<string, Dictionary<string, double>>();

            string[] files = Directory.GetFiles(path, "*");

            foreach (string filePath in files)
            {
                string fileName = Path.GetFileName(filePath);
                string extension = Path.GetExtension(filePath);
                double size = new FileInfo(filePath).Length/1024.0;

                if (!filesInfo.ContainsKey(extension))
                {
                    filesInfo.Add(extension, new Dictionary<string, double>());
                }

                filesInfo[extension].Add(fileName, size);
            }
            var sb = new StringBuilder();

            foreach (var keyValuePair in filesInfo.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                sb.AppendLine(keyValuePair.Key);

                foreach (var item in keyValuePair.Value.OrderBy(x=>x.Value))
                {
                    sb.AppendLine($"--{item.Key} - {item.Value:F3}kb");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string reportContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            File.WriteAllText(path, reportContent);

        }
    }
}
