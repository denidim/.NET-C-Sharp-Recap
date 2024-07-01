namespace CaesarChipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine()!.Select(x => x = (char)((int)x + 3)).ToArray();
            Console.WriteLine(new string(text));

            //char[] chars = text.ToCharArray();

            //for (int i = 0; i < chars.Length; i++)
            //{
            //    int curr = chars[i]+3;

            //    chars[i] = (char)curr;
            //}

            //Console.WriteLine(new string(chars));
        }
    }
}
