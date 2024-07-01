namespace HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine()!.Split());
            int num = int.Parse(Console.ReadLine()!);

            while (kids.Count>1)
            {
                for (int i = 1; i < num; i++)
                {
                    string removed = kids.Dequeue();
                    kids.Enqueue(removed);
                }
                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
