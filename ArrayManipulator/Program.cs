namespace ArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commands[0] == "end")
                {
                    Console.WriteLine($"[{string.Join(", ", array)}]");
                    break;
                }

                if (commands[0] == "exchange")
                {
                    int index = int.Parse(commands[1]);

                    if (!IsInRange(index, array))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(array, index);
                }
                else if (commands[0] == "max" || commands[0] == "min")
                {
                    if (commands[0] == "max")
                    {
                        if (commands[1] == "even")
                        {
                            if (!CheckIfNumberExists(array, commands[1]))
                            {
                                Console.WriteLine("No matches");
                            }
                            int indexOf = FindIndexOfMaxElement(array, commands[1]);

                            Console.WriteLine(indexOf);
                        }
                        else if (commands[1] == "odd")
                        {
                            if (!CheckIfNumberExists(array, commands[1]))
                            {
                                Console.WriteLine("No matches");
                            }
                            int indexOf = FindIndexOfMaxElement(array, commands[1]);

                            Console.WriteLine(indexOf);
                        }
                    }
                    else if (commands[0] == "min")
                    {
                        if (commands[1] == "even")
                        {
                            if (!CheckIfNumberExists(array, commands[1]))
                            {
                                Console.WriteLine("No matches");
                            }
                            int indexOf = FindIndexOfMinElement(array, commands[1]);

                            Console.WriteLine(indexOf);
                        }
                        else if (commands[1] == "odd")
                        {
                            if (!CheckIfNumberExists(array, commands[1]))
                            {
                                Console.WriteLine("No matches");
                            }
                            int indexOf = FindIndexOfMinElement(array, commands[1]);

                            Console.WriteLine(indexOf);
                        }
                    }
                }
                else if (commands[0] == "first" || commands[0] == "last")
                {
                    int count = int.Parse(commands[1]);

                    if (count > array.Length)
                    {
                        Console.WriteLine("Invalid count");

                        continue;
                    }
                    if (commands[0] == "first")
                    {
                        if (commands[2] == "even")
                        {
                            if (!CheckIfNumberExists(array, commands[1]))
                            {
                                Console.WriteLine("[]");

                                continue;
                            }
                            string result = ReturnElements(array, count, commands[0], commands[2]);

                            Console.WriteLine($"[{result}]");
                        }
                        else if (commands[2] == "odd")
                        {
                            if (!CheckIfNumberExists(array, commands[1]))
                            {
                                Console.WriteLine("[]");

                                continue;
                            }
                            string result = ReturnElements(array, count, commands[0], commands[2]);

                            Console.WriteLine($"[{result}]");
                        }
                    }
                    else if (commands[0] == "last")
                    {
                        if (commands[2] == "even")
                        {
                            if (!CheckIfNumberExists(array, commands[1]))
                            {
                                Console.WriteLine("[]");

                                continue;
                            }
                            string result = ReturnElements(array, count, commands[0], commands[2]);

                            Console.WriteLine($"[{result}]");
                        }
                        else if (commands[2] == "odd")
                        {
                            if (!CheckIfNumberExists(array, commands[1]))
                            {
                                Console.WriteLine("[]");

                                continue;
                            }
                            string result = ReturnElements(array, count, commands[0], commands[2]);

                            Console.WriteLine($"[{result}]");
                        }
                    }
                }
            }
        }

        private static void Exchange(int[] array, int index)
        {
            for (int i = 0; i <= index; i++)
            {
                int temp = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }

                array[array.Length - 1] = temp;
            }
        }

        private static string ReturnElements(int[] array, int count, string firstOrLast, string evenOrOdd)
        {
            Func<int, bool> predicate;
            if (evenOrOdd == "even")
            {
                predicate = x => x % 2 == 0;
            }
            else
            {
                predicate = x => x % 2 != 0;
            }

            var allEvenOrOdd = array.Where(predicate).ToArray();

            if (count >= allEvenOrOdd.Length)
            {
                count = allEvenOrOdd.Length;
            }
            var strArr = allEvenOrOdd.Select(x => x.ToString()).ToArray();

            if (firstOrLast == "first")
            {
                return string.Join(", ", strArr, 0, count);
            }
            else
            {
                int startIndex = strArr.Length - count;
                return string.Join(", ", strArr, startIndex, count);
            }
        }

        private static bool CheckIfNumberExists(int[] array, string evenOrOdd)
        {
            Func<int, bool> predicate;

            if (evenOrOdd == "even")
            {
                predicate = x => x % 2 == 0;
            }
            else
            {
                predicate = x => x % 2 != 0;
            }

            return array.Any(predicate);
        }

        private static int FindIndexOfMinElement(int[] array, string evenOrOdd)
        {
            int indexOf;
            if (evenOrOdd == "even")
            {
                int minEven = int.MaxValue;

                foreach (var item in array)
                {
                    if (item < minEven && item % 2 == 0)
                    {
                        minEven = item;
                    }
                }

                indexOf = Array.LastIndexOf(array, minEven);
            }
            else
            {
                int minEven = int.MaxValue;

                foreach (var item in array)
                {
                    if (item < minEven && item % 2 != 0)
                    {
                        minEven = item;
                    }
                }

               indexOf = Array.LastIndexOf(array, minEven);
            }
            return indexOf;
        }

        private static int FindIndexOfMaxElement(int[] array, string evenOrOdd)
        {
            int indexOf;
            if (evenOrOdd == "even")
            {
                int maxEven = 0;

                foreach (var item in array)
                {
                    if (item > maxEven && item % 2 == 0)
                    {
                        maxEven = item;
                    }
                }

                indexOf = Array.LastIndexOf(array, maxEven);
            }
            else
            {
                int maxOdd = 0;

                foreach (var item in array)
                {
                    if (item > maxOdd && item % 2 != 0)
                    {
                        maxOdd = item;
                    }
                }

                indexOf = Array.LastIndexOf(array, maxOdd);
            }
            return indexOf;
        }

        private static bool IsInRange(int index, int[] arr)
        {
            if (index < arr.Length && index >= 0)
            {
                return true;
            }

            return false;
        }
    }
}