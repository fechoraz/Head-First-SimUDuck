using ConsoleApp.BestPractice.FlyBehaviors;
using ConsoleApp.BestPractice.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new Squeak();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck.");
        }
    }
}
