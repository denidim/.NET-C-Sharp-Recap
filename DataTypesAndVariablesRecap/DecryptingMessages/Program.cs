namespace DecryptingMessages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string pass = "";

            for (int i = 0; i < n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                int num = key + (int)ch;
                char newChar = (char)num;
                pass += newChar;
            }
            Console.WriteLine(pass);
        }
    }
}