using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice.QuackBehaviors
{
    public class Quack
        : IQuackBehavior
    {
        public void MakeQuack()
        {
            Console.WriteLine("Quack");
        }
    }
}
