using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            if(numbers.Count <= 3)
            {
                Console.WriteLine($"{string.Join(" ",numbers.OrderByDescending(x=>x))}");
            }
            else
            {
                Console.WriteLine($"{string.Join(" ", numbers.OrderByDescending(x=>x).Take(3))}");
            }
        }
    }
}
