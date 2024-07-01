namespace SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            char[,] matrix = new char[n,n];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string line = Console.ReadLine()!;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j];
                }
            }

            bool isTrue = false;
            string ch = Console.ReadLine()!;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j].ToString() == ch)
                    {
                        isTrue = true;
                        Console.WriteLine($"({i}, {j})");
                        break;
                    }
                }
                if (isTrue)
                {
                    break;
                }
            }
            if(isTrue == false)
            {
                Console.WriteLine($"{ch} does not occur in the matrix");
            }
            
        }
        public static int[] ReadIntArray()
        {
            return Console.ReadLine()!
                .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
        }
    }
}
