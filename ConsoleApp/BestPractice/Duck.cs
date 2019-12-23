using ConsoleApp.BestPractice.FlyBehaviors;
using ConsoleApp.BestPractice.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        protected Duck()
        {
            
        }

        public abstract void Display();

        public virtual void Swim()
        {
            Console.WriteLine("I'm swimming.");
        }

        public void PerformQuack() 
        {
            QuackBehavior.MakeQuack();
        }

        public void PerformFly() 
        {
            FlyBehavior.MakeFly();
        }

        


    }
}
