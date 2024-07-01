namespace CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()!.Split();
            Console.WriteLine(MultiplyCharCode(strings[0],strings[1]));
        }

        static int MultiplyCharCode(string a, string b)
        {
            int result = 0;

            if (a.Length > b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (i < b.Length)
                    {
                        result += a[i] * b[i];
                    }
                    else
                    {
                        result += a[i];
                    }
                }
            }
            else if (b.Length > a.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (i < a.Length)
                    {
                        result += a[i] * b[i];
                    }
                    else
                    {
                        result += b[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < b.Length; i++)
                {
                    result += a[i] * b[i];
                }
            }
            return result;
        }
    }
}
