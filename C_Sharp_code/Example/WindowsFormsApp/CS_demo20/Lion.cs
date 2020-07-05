using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_demo20
{
    public class Lion : Animal
    {
        //隱含呼叫預設建構式
        public override void talk()
        {
            Console.WriteLine("Lion Talk");
        }
    }
}