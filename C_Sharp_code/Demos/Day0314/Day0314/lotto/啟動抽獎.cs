using Day0314.lotto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day0314.NewFolder1
{
    class Class1
    {
        static void Main(string[] args)
        {
            List<樂透球> ary = new List<樂透球>();

            for (int i = 1; i < 49; i++)
            {

                樂透球 ball = new 樂透球(i);
                ary.Add(ball);
            }
            Random r = new Random();

            for (int i = 1; i < 9; i++)
            {
                int rd = r.Next(ary.Count);
                Console.Write(ary[rd].num+"\t");
                ary.Remove(ary[rd]);
            }
            Console.WriteLine();
            Console.WriteLine("剩餘號碼");
            foreach (樂透球 t in ary)
            {
                Console.Write(t.num+"\t");
            }
        }
    }
}
