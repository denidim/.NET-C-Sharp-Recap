namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();

                box.elements.Add(s);
            }

            string[] arr = Console.ReadLine().Split();

            box.Swap(int.Parse(arr[0]), int.Parse(arr[1]));

            Console.WriteLine(box.ToString());
        }
    }
}
