namespace ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine()!.Split(", ");

            bool isTrue = false;

            for (int i = 0; i < userNames.Length; i++)
            {
                string name = userNames[i];

                if (name.Length >= 3 && name.Length <= 16)
                {
                    for (int j = 0; j < name.Length; j++)
                    {
                        char c = name[j];

                        if (Char.IsLetter(c) || Char.IsDigit(c) || c == '-' || c == '_')
                        {
                            isTrue = true;
                        }
                        else
                        {
                            isTrue = false;
                            break;
                        }
                    }
                    if (isTrue)
                    {
                        Console.WriteLine(name);
                    }
                }
                
            }
        }
    }
}
