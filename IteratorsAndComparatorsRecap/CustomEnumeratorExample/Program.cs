namespace CustomEnumeratorExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            //foreach (var item in person)
            //{
            //    Console.WriteLine(item);
            //}

            var enumerator = person.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.WriteLine(item);
            }
        }
    }
}
