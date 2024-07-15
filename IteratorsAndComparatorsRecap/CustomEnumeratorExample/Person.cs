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
            for (int i = this.Grades.Length - 1; i >= 0; i--)
            {
                yield return Grades[i];
            }

            //return new ReversePersonGradesCustomEnumerator(Grades);
        }

        // Legacy
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}