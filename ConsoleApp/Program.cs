using ConsoleApp.BestPractice;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformanceQuack();
            mallard.PerformanceFly();
            Console.ReadKey();
        }
    }
}
