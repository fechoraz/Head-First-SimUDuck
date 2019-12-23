using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp.BestPractice.FlyBehaviors;
using ConsoleApp.BestPractice.QuackBehaviors;

namespace ConsoleApp.BestPractice
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }
    

        public override void Display()
        {
           Console.WriteLine("I'm a model duck");
        }
    }
}
