using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interface
{
    public abstract class Duck
    {
        public Duck()
        {

        }
        
        public virtual void Swim()
        {
            Console.WriteLine("I'm swimming.");
        }        

        public abstract void Display();
    }
}
