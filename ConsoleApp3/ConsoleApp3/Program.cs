using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Calculator.Plus(3, 4);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
    class Calculator
    {
        public static int Plus (int a, int b)
        {
            Console.WriteLine("Input : {0}, {1}", a, b);
            int result = a + b;
            return result;
        }
    }
}
