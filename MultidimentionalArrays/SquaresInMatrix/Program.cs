namespace SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = ReadIntArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                char[] input = Console.ReadLine()!.Split().Select(char.Parse).ToArray();
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] += input[j];
                }
            }

            int count = 0;

            for (int row = 0; row < size[0] - 1; row++)
            {
                for (int col = 0; col < size[1] - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        private static int[] ReadIntArray()
        {
            return Console.ReadLine()!
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}