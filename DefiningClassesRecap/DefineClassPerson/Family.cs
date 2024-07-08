namespace DefineClassPerson
{
    internal class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; set; }

        public void AddMember(Person person)
        {
            People.Add(person);
        }

        public Person GetOldestMember() => People.OrderByDescending(x => x.Age).First();
    }
}
