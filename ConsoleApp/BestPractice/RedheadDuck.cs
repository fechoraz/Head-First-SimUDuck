using ConsoleApp.BestPractice.FlyBehaviors;
using ConsoleApp.BestPractice.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {            
            Console.WriteLine("I'm a Redhead Duck.");
        }

    }
}
