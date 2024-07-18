namespace StackOfStrings
{
    internal class MyStack : Stack<string>
    {
        public void AddRange(params string[] values)
        {
            foreach (string value in values)
            {
                base.Push(value);
            }
        }

    }
}
