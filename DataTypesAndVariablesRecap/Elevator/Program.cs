﻿namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int coursesNeeded = (int)Math.Ceiling((double)numberOfPeople / capacity);
            Console.WriteLine(coursesNeeded);
        }
    }
}