namespace RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            list = list.FindAll(x => x >= 0);

            list.Reverse();

            if(list.Count > 0)
            {
                Console.WriteLine(string.Join(' ', list));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}