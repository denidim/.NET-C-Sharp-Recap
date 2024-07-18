namespace People
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Pesho";//Console.ReadLine();
            int age = 12;//int.Parse(Console.ReadLine());

            Person person;

            if (age <= 15)
            {
                person = new Child(name, age);
            }
            else
            {
                person = new Person(name, age);
            }

            Console.WriteLine(person);
        }
    }
}
