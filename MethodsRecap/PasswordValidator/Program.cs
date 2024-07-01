namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            CheckPass(pass);
        }

        private static void CheckPass(string? pass)
        {

            bool charCheck = CheckCharacters(pass);
            if (charCheck == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            bool letterAndDigitCheck = CheckLetterAndDigits(pass);
            if(letterAndDigitCheck == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool atLeastTwoDigitsCheck = CheckTwoDigits(pass);
            if (atLeastTwoDigitsCheck == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if(charCheck && letterAndDigitCheck && atLeastTwoDigitsCheck)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckTwoDigits(string? pass)
        {
            int count = pass.Count(x=>char.IsDigit(x));

            if(count < 2)
            {
                return false;
            }

            return true;
        }

        private static bool CheckLetterAndDigits(string? pass)
        {
            foreach (var item in pass)
            {
                if(!char.IsLetter(item) && !char.IsDigit(item))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckCharacters(string? pass)
        {
            if (pass.Length < 6 || pass.Length > 10)
            {
                return false;
            }
            return true;
        }
    }
}