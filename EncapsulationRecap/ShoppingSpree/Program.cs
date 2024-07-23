namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string[] peopleInput = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

            SetupPeople(people, peopleInput);

            List<Product> products = new List<Product>();

            string[] productInput = Console.ReadLine()
                    .Split(';', StringSplitOptions.RemoveEmptyEntries);

            SetupProducts(products, productInput);


            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] cmdArgs = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string personName = cmdArgs[0];
                string productName = cmdArgs[1];

                Person person = people.FirstOrDefault(p => p.Name == personName);

                Product product = products.FirstOrDefault(p => p.Name == productName);

                if (person.Money < product.Cost)
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                    input = Console.ReadLine();
                    continue;
                }

                try
                {
                    person.DecreaseMoney(product.Cost);

                    person.Add(product);

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                if (person.BagOfProduct.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(" ," , person.BagOfProduct.Select(x=>x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }

        private static void SetupProducts(List<Product> products, string[] productInput)
        {
            foreach (var item in productInput)
            {
                string[] cmdArgs = ParseCommand(item);

                string name = cmdArgs[0];
                decimal cost = decimal.Parse(cmdArgs[1]);

                try
                {
                    Product product = new Product(name, cost);
                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        private static void SetupPeople(List<Person> people, string[] peopleInput)
        {
            foreach (var item in peopleInput)
            {
                string[] cmdArgs = ParseCommand(item);

                string name = cmdArgs[0];
                decimal money = decimal.Parse(cmdArgs[1]);

                try
                {
                    Person person = new Person(name, money);
                    people.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }

        private static string[] ParseCommand(string item)
        {
            return item.Split('=', StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
