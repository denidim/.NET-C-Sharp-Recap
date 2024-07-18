namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cake = new Dessert("Cake", 5, 250, 1000);
            var soup = new Starter("Soup", 3, 200);
            var Fish = new MainDish("Fish", 6, 22);
        }
    }
}
