using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo20
{
    public class Animal
    {
        private string _name;

        public Animal():this("no name")
        {
            
        }
        public Animal(string argName)
        {
            this._name = argName;
        }

        public string Name
        {
            get {
                return _name;
            }      
          
            set//隱含傳遞參數value
            {
                _name = value;
            }
        }             

        public virtual void talk()
        {
            Console.WriteLine("Animal Talk");
        }
    }
}