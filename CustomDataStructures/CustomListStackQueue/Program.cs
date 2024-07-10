namespace CustomListStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList customList = new CustomList();

            customList.Add(5);
            // must contain 5

            customList.Add(10);//5, 10
            int removed = customList.RemoveAt(1);
            Console.WriteLine(removed); // 10
            // must contain 5

            Console.WriteLine(customList.Count);
            // 1

            customList.Add(7);//5,7
            bool contains = customList.Contains(5);
            Console.WriteLine(contains);
            //true

            customList.Swap(0, 1);
            //7 5

            Console.WriteLine(customList[0]);//7
            Console.WriteLine(customList[1]);//5
        }
    }
}
