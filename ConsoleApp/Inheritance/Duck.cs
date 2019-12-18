using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Inheritance
{
    public abstract class Duck
    {
        public Duck()
        {

        }

        public virtual void Quack() 
        {
            Console.WriteLine("I'm quacking.");
        }

        public virtual void Swim()
        {
            Console.WriteLine("I'm swimming.");
        }

        public virtual void Fly() 
        {
            Console.WriteLine("I'm flying.");
        }

        public abstract void Display();
    }
}
