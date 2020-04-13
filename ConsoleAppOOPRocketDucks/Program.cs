using ConsoleAppOOPRocketDucks.Models;
using System;
using System.Runtime.InteropServices;

namespace ConsoleAppOOPRocketDucks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RocketDuck rd = new RocketDuck();

            Console.WriteLine(rd is IQuackable);
            Console.WriteLine(rd is IFlyable);
            Console.WriteLine(rd is IRocketable);

            Console.ReadKey();
        }
    }
}
