namespace SliceMe
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int parts = 4;

            byte[] buffer = new byte[4096];

            int totalBytes = 0;

            using (FileStream fs = new FileStream("sliceMe.txt", FileMode.Open, FileAccess.Read))
            {
                long partSize = (long)Math.Ceiling((decimal)fs.Length / parts);

                for (int i = 1; i <= parts; i++)
                {
                    int readBytes = 0;

                    using (FileStream output = new FileStream($"Part-{i}.txt",FileMode.Create,FileAccess.Write))
                    {

                        while (readBytes<partSize)
                        {
                            int bytes = await fs.ReadAsync(buffer, totalBytes, buffer.Length);

                            await output.WriteAsync(buffer, readBytes, bytes);

                            readBytes += bytes;

                            totalBytes += bytes;
                        }
                    }
                }
            }
        }
    }
}
