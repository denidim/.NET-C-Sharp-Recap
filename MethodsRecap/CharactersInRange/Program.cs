namespace CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            PrintASCII(a, b);

        }

        private static void PrintASCII(char a, char b)
        {
            if (a < b)
            {
                for (int i = (int)a + 1; i < (int)b; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = (int)b + 1; i < (int)a; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}