namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            long[][] jagged = new long[n][];
            jagged[0] = new long[1];
            jagged[0][0] = 1;
            for (int row = 1; row < n; row++)
            {
                jagged[row] = new long[row + 1];
                for (int col = 0; col < row + 1; col++)
                {
                    long left = 0;
                    long right = 0;

                    if (IsInMatrix(jagged, row - 1, col - 1))
                    {
                        left = jagged[row - 1][col - 1];
                    }
                    if (IsInMatrix(jagged, row - 1, col))
                    {
                        right = jagged[row - 1][col];
                    }

                    jagged[row][col] = left + right;
                }
            }
            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(" ", jagged[i]));
            }
        }
        static bool IsInMatrix<T>(T[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0)
                && col >= 0 && col < matrix[row].Length;
        }
    }
}
