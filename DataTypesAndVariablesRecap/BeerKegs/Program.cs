namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string modelResult = "";
            double volumeResult = 0;

            for (int i = 0; i < length; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > volumeResult)
                {
                    volumeResult = volume;
                    modelResult = model;
                }
            }

            Console.WriteLine(modelResult);
        }
    }
}