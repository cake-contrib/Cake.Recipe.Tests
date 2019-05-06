using System;
using MathLibrary;

namespace TestConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = ".NET Core Test Console";
            Console.WriteLine($"2 + 2 = {MathClass.Add(2, 2)}");
        }
    }
}