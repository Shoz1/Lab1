using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number and press enter: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number and press enter: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("result=" + (a*b));
        }

    }
}
