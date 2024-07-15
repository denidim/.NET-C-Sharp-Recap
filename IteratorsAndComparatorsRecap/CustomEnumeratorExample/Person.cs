using System.Collections;

namespace CustomEnumeratorExample
{
    internal class Person : IEnumerable<int>
    {
        public string? Name { get; set; }

        public int Age { get; set; }

        public int[] Grades { get; set; } = [1, 2, 3];

        public IEnumerator<int> GetEnumerator()
        {
            return new ReversePersonGradesCustomEnumerator(Grades);
        }

        // Legacy
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}