﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Interface
{
    public class DecoyDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck.");
        }
    }
}
