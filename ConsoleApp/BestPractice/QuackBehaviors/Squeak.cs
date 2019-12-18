using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice.QuackBehaviors
{
    public class Squeak
        : IQuackBehavior
    {
        public void MakeQuack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
