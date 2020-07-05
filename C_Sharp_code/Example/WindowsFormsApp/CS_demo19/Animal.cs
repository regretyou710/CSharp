using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo19
{
    public class Animal
    {
        internal string _name;        
        public Animal()
        {
            Console.WriteLine("This's animal construtor()");
        }
        public Animal(string name)
        {
            this._name = name;
            Console.WriteLine("This's animal constructor(string)");
        }
    }
}