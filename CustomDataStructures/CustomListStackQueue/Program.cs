namespace CustomListStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack customStack = new CustomStack();

            customStack.Push(1);
            customStack.Push(2);
            customStack.Push(3);
            customStack.Push(4);
            customStack.Push(5);
            
            Console.WriteLine(customStack.Count == 5);

            Console.WriteLine(customStack.Pop() == 5);

            Console.WriteLine(customStack.Pop() == 4);

            Console.WriteLine(customStack.Count == 3);

            Console.WriteLine(customStack.Peek() == 3);

            customStack.ForEach(x => Console.WriteLine(x));
        }
    }
}
