using System;

namespace ConsoleProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "VS2015 Console Project Test";

            Console.WriteLine("2 + 2 = {0}", MathClass.Add(2, 2));
        }
    }
}