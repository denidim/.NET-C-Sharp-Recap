namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            if(str.Length %2 == 0)
            {
                Console.Write($"{str[str.Length / 2 -1]}{str[str.Length / 2]}");
            }
            else
            {
                Console.WriteLine(str[str.Length/2]);
            }
        }
    }
}