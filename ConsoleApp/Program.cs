using ConsoleApp.Inheritance;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.Display();
            duck.Quack();
            duck.Swim();
            duck.Fly();
            Console.ReadKey();
        }
    }
}
