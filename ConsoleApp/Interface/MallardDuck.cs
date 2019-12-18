using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interface
{
    public class MallardDuck 
        : Duck, IQuackable, IFLyable
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck.");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        public void Quack()
        {
            Console.WriteLine("I'm quacking");
        }
    }
}