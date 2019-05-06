using System;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ".NET Core Test Console";
            Console.WriteLine($"2 + 2 = {MathLibrary.MathClass.Add(2, 2)}");
        }
    }
}
