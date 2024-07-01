namespace LineNumbers
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var sr = new StreamReader("input.txt"))
            {
                string? line = await sr.ReadLineAsync();

                using (var writer = new StreamWriter("../../../Output.txt"))
                {
                    int counter = 1;

                    while (line != null)
                    {
                        await writer.WriteLineAsync($"{counter}. {line}");

                        counter++;        
                        line = await sr.ReadLineAsync();
                    }
                }
            }
        }
    }
}
