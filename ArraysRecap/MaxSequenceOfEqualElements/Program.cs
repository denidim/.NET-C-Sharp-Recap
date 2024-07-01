namespace MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstNum = 0;
            int currentCount = 1;
            int bestCount = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i-1] == nums[i])
                {
                    currentCount++;

                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        firstNum = nums[i];
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{firstNum} ");
            }
        }
    }
}