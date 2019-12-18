using ConsoleApp.BestPractice.FlyBehaviors;
using ConsoleApp.BestPractice.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {
            
        }

        public virtual void Swim()
        {
            Console.WriteLine("I'm swimming.");
        }

        public void PerformanceQuack() 
        {
            quackBehavior.MakeQuack();
        }

        public void PerformanceFly() 
        {
            flyBehavior.Fly();
        }

        public abstract void Display();


    }
}
