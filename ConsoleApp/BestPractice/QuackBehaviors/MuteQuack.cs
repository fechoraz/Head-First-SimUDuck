using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice.QuackBehaviors
{
    public class MuteQuack 
        : IQuackBehavior
    {
        public void MakeQuack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
