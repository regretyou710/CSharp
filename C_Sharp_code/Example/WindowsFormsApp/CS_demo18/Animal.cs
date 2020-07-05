using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo18
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Animal Eat");
        }
        public string speak()
        {
            return "Animal Speak";
        }
    }
    class Lion : Animal
    {

    }
    class Horse : Animal { }
}
