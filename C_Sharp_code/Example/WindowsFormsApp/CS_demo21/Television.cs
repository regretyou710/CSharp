using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo21
{
    public abstract class Television
    {
        public abstract void increaseVolume();

        public abstract void decreaseVolume();

        public void turnOff()
        {
            Console.WriteLine("television off");
        }

        public void turnOn()
        {
            Console.WriteLine("television on");
        }
    }
}