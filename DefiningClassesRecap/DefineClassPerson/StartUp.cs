namespace DefineClassPerson
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person("Stoyan", 12);
            Console.WriteLine(person.Name);
        }
    }
}
