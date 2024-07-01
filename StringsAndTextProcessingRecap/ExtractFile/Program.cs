namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()!.Split('.');
            string[] name = input[0].Split('\\');
            Console.WriteLine($"File name: {name[name.Length - 1]}");
            Console.WriteLine($"File extension: {input[1]}");
        }
    }
}
