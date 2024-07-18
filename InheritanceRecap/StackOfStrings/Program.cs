namespace StackOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myStack = new MyStack();

            Console.WriteLine(myStack.IsEmpty());

            myStack.AddRange("cat", "dog", "camel");

            Console.WriteLine(myStack.IsEmpty()); 
        }
    }
}
