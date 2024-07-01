namespace RepeatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();
            string result = "";

            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings[i].Length; j++)
                {
                    result += strings[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
