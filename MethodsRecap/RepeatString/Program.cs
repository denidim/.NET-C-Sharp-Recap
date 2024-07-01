namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = Repeat(str, n);
            Console.WriteLine(result);
        }

        private static string Repeat(string str, int n)
        {
            string newStr = string.Empty;

            for (int i = 0; i < n; i++)
            {
                newStr += str;
            }

            return newStr;
        }
    }
}