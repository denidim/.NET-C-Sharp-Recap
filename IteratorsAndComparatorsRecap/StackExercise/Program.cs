namespace StackExercise
{
    internal class Program
    {
        internal static readonly char[] separator = new char[] { ' ', ',' };

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()!
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);

            Stack<int> stack = new Stack<int>();

            while (input[0] != "END")
            {
                if (input[0] == "Push")
                {
                    stack.Push(input
                        .Skip(1)
                        .Select(int.Parse)
                        .ToArray());
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}
