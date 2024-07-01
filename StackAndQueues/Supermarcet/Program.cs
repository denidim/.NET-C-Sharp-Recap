namespace Supermarcet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine()!;
                if(input == "End")
                {
                    break;
                }
                queue.Enqueue(input);
                if (input == "Paid")
                {
                    while (queue.Count > 1)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                    queue.Clear();
                }
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
