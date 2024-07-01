namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }
                bool isPalindrome = PalindromeCheck(input);

                if (isPalindrome)
                {
                    Console.WriteLine(true.ToString().ToLower());
                }
                else
                {
                    Console.WriteLine(false.ToString().ToLower());
                }
            }
           
        }

        private static bool PalindromeCheck(string input)
        {
            string reversed = string.Join("", input.Reverse().ToArray());

            if (input == reversed)
            {
                return true;
            }

            return false;
        }
    }
}