using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo20
{
    //sealed class Car //加上sealed關鍵字 密封不能被繼承
     class Car
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
            _name = value;
            }
        }
        public Car():this("Is Car")
        {

        }
        public Car(string argName)
        {
            this._name = argName;
        }
        public virtual void display()
        {
            Console.WriteLine("Car method");
        }
    }
}
