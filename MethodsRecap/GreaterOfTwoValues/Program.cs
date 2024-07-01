namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                GetMax(firstNumber, secondNumber);
            }
            else if (type == "char")
            {
                char firstCharacter = char.Parse(Console.ReadLine());
                char secondCharacter = char.Parse(Console.ReadLine());

                GetMax(firstCharacter, secondCharacter);
            }
            else if (type == "string")
            {
                string firstString = Console.ReadLine();
                string secondString = Console.ReadLine();

                GetMax(firstString, secondString);
            }

        }

        private static void GetMax(string? firstString, string? secondString)
        {

            if (String.Compare(firstString, secondString) > 0)
            {
                Console.WriteLine(firstString);
            }
            else
            {
                Console.WriteLine(secondString);
            }
        }

        private static void GetMax(int firstNumber, int secondNumber)
        {
            Console.WriteLine(Math.Max(firstNumber, secondNumber));
        }

        private static void GetMax(char firstChar, char secondChar)
        {
            Console.WriteLine((char)Math.Max(firstChar, secondChar));
        }
    }
}