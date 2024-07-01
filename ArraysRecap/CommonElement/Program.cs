namespace CommonElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split().ToArray();

            string[] secondArr = Console.ReadLine().Split().ToArray();

            foreach (string str in firstArr)
            {
                foreach (string str2 in secondArr)
                {
                    if(str == str2)
                    {
                        Console.Write($"{str} ");
                    }
                }
            }
        }
    }
}