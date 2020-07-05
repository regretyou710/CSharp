using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day0314
{
    class Demo1
    {
        static void Main(string[] args)
        {
            int[] ary = new int[5];
            for (int i = 0; i < ary.Length; i++)
            {
                Console.WriteLine("請輸入第" + (i + 1) + "個數字:");
                string str = Console.ReadLine();                
                int.TryParse(str, out ary[i]);
            }
            foreach (int i in ary)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine("由大到小排序\n\r");
            for (int j=0; j<ary.Length-1;j++)
            {
                for (int k =j+1; k<ary.Length;k++)
                {
                    int tmp = 0;
                    if (ary[k]>ary[j])
                    {
                        tmp = ary[j];
                        ary[j] = ary[k];
                        ary[k] = tmp;
                    }
                }
            }
            foreach (int i in ary)
            {
                Console.Write(i + "\t");
            }
        }

    }
}
