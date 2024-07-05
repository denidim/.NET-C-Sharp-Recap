
namespace CopyAllFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPath = @"C:\Users\fs900\Desktop\.NET-C-Sharp-Recap\StreamsRecap\DirectoryTraversal"; //Console.ReadLine()!;
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string outputPath = $@"{desktop}\here";//Console.ReadLine()!;

            CopyAllFiles(inputPath, outputPath);
        }

        private static void CopyAllFiles(string inputPath, string outputPath)
        {
            if (Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath, true);
            }

            Directory.CreateDirectory(outputPath);

            string[] files = Directory.GetFiles(inputPath);

            
            foreach (var item in files)
            {
                string fileName = outputPath + "\\" + Path.GetFileName(item);
                File.Copy(item, fileName);
            }
        }
    }
}
