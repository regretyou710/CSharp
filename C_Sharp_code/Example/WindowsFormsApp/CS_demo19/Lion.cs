using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo19
{
    public class Lion : Animal
    {
        public Lion()
        {

            Console.WriteLine("This's Lion constructor()");
        }
        public Lion(string name) : base(name)
        {
            //base._name = name;
            Console.WriteLine("This's Lion constructor(string)");
        }

    }
}