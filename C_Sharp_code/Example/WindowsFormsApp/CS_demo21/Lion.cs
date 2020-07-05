using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo21
{
    public class Lion : Animal, ICarnivore, IComparable
    {
        private bool hungry;
        public string name;
        public Lion()
        {
            hungry = true;
        }
        public Lion(string name)
        {
            this.name = name;
        }

        bool ICarnivore.IsHungry
        {
            get
            {
                return hungry;
            }
        }

        public override void sleep()
        {
            Console.WriteLine("獅子在睡覺");
        }

        void ICarnivore.Eat(Animal victim)
        {
            Console.WriteLine("獅子吃獵物 " + victim);
        }

        Animal ICarnivore.Hunt()
        {
            //狩獵到羚羊
            return new Antelope();
        }

        public int CompareTo(object obj)
        {
            Lion x;
            x = (Lion)obj;
            //Lion自己本身的物件name和傳遞進來的物件name做比較
            //本身大於傳遞進來,回傳正值,反之則回傳負值
            return this.name.CompareTo(x.name);
        }
    }
}