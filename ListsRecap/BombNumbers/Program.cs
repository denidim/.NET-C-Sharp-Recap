namespace BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = numbers[0];
            int power = numbers[1];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber)
                {
                    int leftRange = GetMinRange(list, bombNumber, power);
                    int rightRange = GetMAxRange(list, bombNumber, power);
                    int startIndex = list.IndexOf(bombNumber)-leftRange;
                    int count = leftRange + rightRange + 1;
                    list.RemoveRange(startIndex, count);
                    i = 0;
                }
            }
            Console.WriteLine(list.Sum());
        }

        private static int GetMAxRange(List<int> list, int bombNumber, int range)
        {
            int index = list.IndexOf(bombNumber);

            int maxPossibleRange = list.Count - 1 - index;

            if (range > maxPossibleRange)
            {
                range = maxPossibleRange;
            }
            return range;
        }

        private static int GetMinRange(List<int> list, int bombNumber, int range)
        {
            int index = list.IndexOf(bombNumber);

            int minPossibleRange = index;

            if (range > minPossibleRange)
            {
                range = minPossibleRange;
            }
            return range;
        }
    }
}
