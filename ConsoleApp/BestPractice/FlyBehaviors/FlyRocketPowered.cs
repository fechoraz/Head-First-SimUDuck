using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.BestPractice.FlyBehaviors
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void MakeFly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
