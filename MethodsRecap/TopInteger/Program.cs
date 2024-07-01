namespace TopInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopNumber(int n)
        {
            if (IsDivisible(n) && HasOddDigit(n))
            {
                return true;
            }
            return false;
        }

        private static bool HasOddDigit(int n)
        {
            while (n > 0)
            {
                if(n%2!=0)
                {
                    return true;
                }

                n /= 10;
            }
            return false;
        }

        private static bool IsDivisible(int n)
        {
            int sum = n.ToString().Sum(x => int.Parse(x.ToString()));

            if (sum % 8 == 0)
            {
                return true;
            }

            return false;
        }
    }
}