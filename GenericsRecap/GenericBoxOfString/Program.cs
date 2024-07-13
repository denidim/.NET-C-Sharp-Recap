namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<int> box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                box.elements.Add(int.Parse(Console.ReadLine()));
            }

            string[] arr = Console.ReadLine().Split();

            box.Swap(int.Parse(arr[0]), int.Parse(arr[1]));

            Console.WriteLine(box.ToString());
        }
    }
}
