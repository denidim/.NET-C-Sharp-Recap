namespace StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i <  input.Length; i++)
            {
                stack.Push(input[i]);
            }
            while (true)
            {
                string[] commands = Console.ReadLine()!.ToLower().Split();

                if (commands[0] == "end")
                {
                    Console.WriteLine($"Sum: {stack.Sum()}");
                    break;
                }

                if (commands[0] == "add")
                {
                    stack.Push(int.Parse(commands[1]));
                    stack.Push(int.Parse(commands[2]));
                }

                if (commands[0] == "remove")
                {
                    int count = int.Parse(commands[1]);

                    if(stack.Count >= count)
                    {
                        for (int i = 0; i < count ; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
        }
    }
}
