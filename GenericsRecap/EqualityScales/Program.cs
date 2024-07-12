namespace EqualityScales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(1, 2);
            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}
