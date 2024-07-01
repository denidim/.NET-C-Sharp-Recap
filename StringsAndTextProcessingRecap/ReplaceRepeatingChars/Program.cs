namespace ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;

            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                char curr = input[i-1];

                if(curr == input[i])
                {
                    count++;
                    if(i== input.Length-1)
                    {
                        string toReplace = new string(curr, count);
                        input = input.Replace(toReplace, curr.ToString());
                    }
                }
                else
                {
                    if (count>1)
                    {
                        string toReplace = new string(curr, count);
                        input=input.Replace(toReplace, curr.ToString());
                        i = 0;
                        count = 1;
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
