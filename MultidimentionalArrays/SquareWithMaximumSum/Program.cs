namespace SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = ReadIntArray();

            int[,] matrix = new int[size[0], size[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = ReadIntArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int maxSum = int.MinValue;
            int sum = 0;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (IsInMatrix(matrix, row + 1, col + 1))
                    {
                        sum += matrix[row, col];
                        sum += matrix[row, col + 1];
                        sum += matrix[row + 1, col];
                        sum += matrix[row + 1, col + 1];
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            bestRow = row;
                            bestCol = col;
                        }
                        sum = 0;
                    }
                }
            }
            Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]}");
            Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]}");
            Console.WriteLine(maxSum);
        }
        public static bool IsInMatrix<T>(T[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                   col >= 0 && col < matrix.GetLength(1);
        }

        private static int[] ReadIntArray()
        {
            return Console.ReadLine()!.Split(", ").Select(int.Parse).ToArray();
        }
    }
}
