namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Test with string
            //for (int i = 0; i < n; i++)
            //{
            //    string s = Console.ReadLine();

            //    Box<string> box = new Box<string>(s);

            //    Console.WriteLine(box.ToString());
            //}

            //Test with int
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                Box<int> box = new Box<int>(num);

                Console.WriteLine(box.ToString());
            }
        }
    }
}
