namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine()!;
            string text = Console.ReadLine()!;

            while (text.Contains(word))
            {
                text = text.Replace(word, string.Empty);
            }
            Console.WriteLine(text);

            //while (text.Contains(word))
            //{
            //    int startIndex = text.IndexOf(word);
            //    int length = word.Length;
            //    text = text.Remove(startIndex, length);
            //}
            //Console.WriteLine(text);
        }
    }
}
