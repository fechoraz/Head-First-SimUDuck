using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interface
{
    public class RubberDuck 
        : Duck, IQuackable
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck.");
        }

        public void Quack()
        {
            Console.WriteLine("I'm squeak");
        }
    }
}
