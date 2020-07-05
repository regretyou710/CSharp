using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtnesionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //對string進行擴充方法
            //擴充方法是使用執行個體方法語法進行呼叫            
            string str = null;//string str = new string();
            string i = str.Add(5,5);            
            Console.WriteLine(i);


            Student st = new Student();
            string info = st._ExtendsionStuInfo();
            Console.WriteLine(info);
            string stuInfo = st._ExtendsionGetStuInfo(5,"Eason");
            Console.WriteLine(stuInfo);
            Console.ReadLine();
        }
    }
}
