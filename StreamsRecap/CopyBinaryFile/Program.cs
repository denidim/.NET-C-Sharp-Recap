namespace CopyBinaryFile
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string inputPath = "../../../copyMe.png";
            string outputPath = "../../../copyMe-copy.png";
            await CopyFile(inputPath, outputPath);
        }

        public static async Task CopyFile(string inputPath, string outputPath)
        {
            byte[] buffer = new byte[4096];

            using var fs = new FileStream(inputPath, FileMode.Open, FileAccess.Read);
            using var outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write);

            while (true)
            {
                int bytes = await fs.ReadAsync(buffer, 0, buffer.Length);

                if (bytes == 0)
                {
                    break;
                }
                await outputStream.WriteAsync(buffer, 0, buffer.Length);
            }
        }
    }
}
