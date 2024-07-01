namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;

            int strength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char curr = input[i];

                if (curr == '>')
                {
                    strength += int.Parse(input[i+1].ToString());
                    input = input.Remove(i+1,1);
                    strength -= 1;
                }
                else
                {
                    if(strength > 0 && i < input.Length)
                    {
                        input = input.Remove(i, 1);
                        strength--;
                        i--;
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
