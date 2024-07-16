namespace StackExercise
{
    internal class Stack<T>
    {
        private readonly List<T> elements;

        public Stack(params T[] elements)
        {
            this.elements = elements.ToList();
        }
    }
}
