namespace GausssTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();

            int end = list.Count / 2;

            for (int i = 0; i < end; i++)
            {
                list[i] += list[list.Count - 1];
                list.RemoveAt(list.Count-1);
            }
            Console.WriteLine(string.Join(' ', list));
        }
    }
}