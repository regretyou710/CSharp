using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo21
{
    public class WidescreenTV : Television
    {
        public override void decreaseVolume()
        {
            Console.WriteLine("volume decrease(WidescreenTV)");
        }

        public override void increaseVolume()
        {
            Console.WriteLine("volume increase(WidescreenTV)");
        }

        public override string ToString()
        {
            return "This's Wide Screen TV";
        }
    }
}