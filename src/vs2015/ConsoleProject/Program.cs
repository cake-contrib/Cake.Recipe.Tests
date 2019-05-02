using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "VS2015 Console Project Test";

            Console.WriteLine("2 + 2 = {0}", MathClass.Add(2, 2));
        }
    }
}
