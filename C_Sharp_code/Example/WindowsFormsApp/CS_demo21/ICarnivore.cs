using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo21
{
    interface ICarnivore
    {
        bool IsHungry
        {
            get;
            //set;
        }
        void Eat(Animal victim);
        Animal Hunt();
    }
}