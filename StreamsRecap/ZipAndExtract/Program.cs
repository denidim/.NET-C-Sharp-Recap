using System.IO.Compression;

namespace ZipAndExtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";

            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }



        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using ZipArchive zip = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);

            zip.CreateEntryFromFile(inputFilePath, "copyMe.png");
        }
        
        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using ZipArchive zip = ZipFile.OpenRead(zipArchiveFilePath);

            ZipArchiveEntry current = zip.GetEntry(fileName)!;

            current.ExtractToFile(outputFilePath);
        }
    }
}
