using System;

namespace ConsoleAppProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "VS2017 Console Project Test";

            Console.WriteLine($"2 + 2 = {MathClass.Add(2, 2)}");
        }
    }
}