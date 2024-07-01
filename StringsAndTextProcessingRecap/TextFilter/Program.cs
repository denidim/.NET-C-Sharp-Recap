namespace TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()!.Split(", ");
            string text = Console.ReadLine()!;

            //for (int i = 0; i < words.Length; i++)
            //{
            //    string word = words[i];
            //    text =text.Replace(word,new string('*',word.Length));
            //}
            //Console.WriteLine(text);

            words.ToList().ForEach(x =>
            {
                text = text.Replace(x, new string('*',x.Length));
            });
            Console.WriteLine(text);
        }
    }
}
