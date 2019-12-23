using ConsoleApp.BestPractice;
using System;
using ConsoleApp.BestPractice.FlyBehaviors;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();


            Duck model = new ModelDuck();
            model.Display();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            Console.ReadKey();
        }
    }
}
