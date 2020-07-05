using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo21
{
    public class Antelope : Animal
    {
        public string name;

        public Antelope()
        {
        }

        public Antelope(string name)
        {
            this.name = name;
        }

        public override void sleep()
        {
            Console.WriteLine("羚羊在睡覺");
        }

        public override string ToString()
        {
            return "這是羚羊";
        }
    }
}