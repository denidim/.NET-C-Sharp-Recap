namespace ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            str = str.Reverse().ToArray();

            Console.Write(String.Join(' ',str));
        }
    }
}