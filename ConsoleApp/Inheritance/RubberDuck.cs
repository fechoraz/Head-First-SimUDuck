using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Inheritance
{
    public class RubberDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck.");
        }

        public override void Quack()
        {
            Console.WriteLine("I'm squeak");
        }
    }
}
