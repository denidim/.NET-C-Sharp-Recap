namespace EqualsArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            int[] arrayTwo = Console.ReadLine()
               .Split(' ')
               .Select(int.Parse)
               .ToArray();

            bool areEqual = true;

            if (arrayOne.Length != arrayTwo.Length)
            {
                areEqual = false;
            }

            int sum = 0;
            int index = 0; 

            for (int i = 0; i < arrayOne.Length; i++)
            {
                sum += arrayOne[i];
                if (arrayOne[i] != arrayTwo[i])
                {
                    index = i;
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine(
                    $"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}