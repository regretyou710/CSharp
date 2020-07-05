using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo20
{
    class Apple
    {
        string _name;
        public Apple(string argName)
        {
            _name = argName;
        }

        public override bool Equals(object b)
        {
            Apple a;
            a = (Apple)b;//將b轉型存到變數a
            if (this._name.Equals(a._name))
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "Name: " + _name;
        }

    }
}
