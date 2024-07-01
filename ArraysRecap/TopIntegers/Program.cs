namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                bool isGreater = true;

                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        isGreater = false;
                        break;
                    }
                }
                if (isGreater)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
        }
    }
}