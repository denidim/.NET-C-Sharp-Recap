namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()!.Split().Reverse().ToArray();
            
            Stack<string> stack = new Stack<string>(input);

            while (stack.Count > 1)
            {
                int a = int.Parse(stack.Pop());
                string opr = stack.Pop();
                int b = int.Parse(stack.Pop());
                int result;

                if (opr == "+")
                {
                    result = a + b;
                    stack.Push(result.ToString());
                }
                else
                {
                    result = a - b;
                    stack.Push(result.ToString());
                }
            }
            Console.WriteLine($"{stack.Pop()}");
        }
    }
}
