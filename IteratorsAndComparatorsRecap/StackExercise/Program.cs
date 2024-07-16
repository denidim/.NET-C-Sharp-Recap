namespace StackExercise
{
    internal class Program
    {
        internal static readonly char[] separator = new char[] { ' ', ',' };

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()!
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
