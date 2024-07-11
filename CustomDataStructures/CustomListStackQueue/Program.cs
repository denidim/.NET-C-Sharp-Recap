namespace CustomListStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

<<<<<<< list
        private static void CustomList()
        {
            CustomList customList = new CustomList();

            customList.Add(5);

            customList.Add(10);//5, 10

            Console.WriteLine($"From indexer: {customList[0]}");//5

            Console.WriteLine($"From indexer: {customList[1]}");//10

            int removed = customList.RemoveAt(1);

            Console.WriteLine($"Removed: {removed}"); // 10

            bool contains = customList.Contains(5);
            // must contain 5

            Console.WriteLine($"Contains 5: {contains}");//true

            Console.WriteLine($"Count: {customList.Count}");// 1

            customList.Add(7);//5,7

            bool contains7 = customList.Contains(7);
            // must contain 7

            Console.WriteLine($"Contains 7: {contains7}");//true

            Console.WriteLine($"Count: {customList.Count}");// 2

            customList.Swap(0, 1);//7 5

            Console.WriteLine($"From indexer: {customList[0]}");//7

            Console.WriteLine($"From indexer: {customList[1]}");//5

            customList.ForEach(x => Console.WriteLine($"From ForEach: {x}"));
=======
        private static void CustomStack()
        {
            CustomStack<int> customStack = new CustomStack<int>();

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
>>>>>>> main
        }
    }
}
