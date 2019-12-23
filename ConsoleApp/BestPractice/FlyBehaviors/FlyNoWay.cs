using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice.FlyBehaviors
{
    public class FlyNoWay
        : IFlyBehavior
    {
        public void MakeFly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
