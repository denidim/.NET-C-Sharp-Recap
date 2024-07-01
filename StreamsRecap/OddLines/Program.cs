namespace OddLines
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var sr = new StreamReader("input.txt"))
            {
                int count = 0;

                string? line = await sr.ReadLineAsync();

                using (var writer = new StreamWriter("output.txt"))
                {
                    while (line != null)
                    {
                        if (count % 2 != 0)
                        {
                            await writer.WriteLineAsync(line);
                        }

                        count++;
                        line = await sr.ReadLineAsync();
                    }
                }
            }
        }
    }
}
