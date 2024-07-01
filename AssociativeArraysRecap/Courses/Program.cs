namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> keyValuePairs = new();

            while (true)
            {
                string input = Console.ReadLine()!;

                if (input == "end")
                {
                    break;
                }

                string course = input.Split(" : ")[0];
                string student = input.Split(" : ")[1];

                if (keyValuePairs.TryGetValue(course, out List<string>? values))
                {
                    if (keyValuePairs[course].Any(x=>x != student))
                    {
                        keyValuePairs[course].Add(student);
                    }
                    continue;
                }

                keyValuePairs.Add(course,new List<string> { student });
            }

            foreach (var courseStudentsPair in keyValuePairs.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{courseStudentsPair.Key}: {courseStudentsPair.Value.Count}");

                foreach (var student in courseStudentsPair.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
