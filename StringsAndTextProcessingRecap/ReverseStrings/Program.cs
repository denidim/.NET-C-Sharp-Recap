namespace ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine()!;
                if(input == "end")
                {
                    break;
                }

                var a = new string(input.Reverse().ToArray());

                Console.WriteLine($"{input} = {a}");
            }
        }
    }
}
