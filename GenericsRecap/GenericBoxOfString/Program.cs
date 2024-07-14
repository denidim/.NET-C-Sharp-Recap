namespace GenericBoxOfString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            var personInfo = new MyTuple<string, string>($"{input[0]} {input[1]}", input[2]);

            string[] nameBeer = Console.ReadLine().Split();

            var beerInfo = new MyTuple<string, int>(nameBeer[0], int.Parse(nameBeer[1]));

            string[] intAndDouble = Console.ReadLine().Split();

            var numbersInfo = new MyTuple<int, double>(int.Parse(intAndDouble[0]), double.Parse(intAndDouble[1]));

            Console.WriteLine(personInfo);
            Console.WriteLine(beerInfo);
            Console.WriteLine(numbersInfo);
        }
    }
}
