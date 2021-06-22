using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();

            kitty.Color = "white";
            kitty.Name = "키티";
            kitty.Meow();

            Cat nero = new Cat();
            nero.Color = "black";
            nero.Name = "nero";
            nero.Meow();

            Console.ReadLine();
        }
    }
     
    class Cat
    {
        public string Name;
        public string Color;
        public void Meow()
        {
            Console.WriteLine("{0} : 야옹", Name);
        }
    }
}
