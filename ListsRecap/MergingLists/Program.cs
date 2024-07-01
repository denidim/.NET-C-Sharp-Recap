namespace MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> listTwo = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            int min = Math.Min(listOne.Count, listTwo.Count);
            int max = Math.Max(listOne.Count,listTwo.Count);
            
            for (int i = 0; i < max; i++)
            {
                if (i < min)
                {
                        result.Add(listOne[i]);
                        result.Add(listTwo[i]);
                }
                else
                {
                    if (listOne.Count > listTwo.Count)
                    {
                        result.Add(listOne[i]);
                    }
                    else
                    {
                        result.Add(listTwo[i]);
                    }
                }
            }

            Console.WriteLine(string.Join(' ',result));
        }
    }
}