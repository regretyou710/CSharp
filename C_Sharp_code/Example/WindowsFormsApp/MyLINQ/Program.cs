using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQ
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {
            123,5485,72138,10,484,3285,141,653,112,74,330,741};


            //找出list中大於500的元素
            {
                //傳統寫法
                List<int> data = new List<int>();
                foreach (int t in list)
                {
                    if (t > 500)
                        data.Add(t);
                }
                //foreach (int t in data)
                //    Console.WriteLine(t);

                //LINQ寫法
                var rs = list.Where<int>(t => t > 500);
                //foreach (int t in rs)
                //    Console.WriteLine(t);
            }


            //找出list中小於100的元素
            {
                //傳統寫法
                List<int> data = new List<int>();
                foreach (int t in list)
                {
                    if (t < 100)
                        data.Add(t);
                }
                //foreach (int t in data)
                //    Console.WriteLine(t);

                //LINQ寫法
                var rs = list.Where<int>(t => t < 100);
                // foreach (int t in rs)
                //    Console.WriteLine(t);
            }

            //...
            //.....
            //有更多過濾條件...

            Func<int, bool> func = new Func<int, bool>(i => i > 500);
            func = i => i > 500;
            //將方法加上靜態
            // Program pr = new Program();
            //pr.getElements(list, func);
            var iteam = getElements(list, func);//用var來推斷型別(LINQ)           
            //foreach (int t in iteam)
            //    Console.WriteLine(t);


            //LINQ變化過程
            {
                //var iteam = getElements(list, func);
                //var iteam = getElements(list,i => i > 500);
                //加上方法擴充
                //var iteam = list.getElements(i => i > 500);//list呼叫擴充的方法
                // var iteam = list.getElements<int>(i => i > 500);//加上泛型
                //var rs = list.Where<int>(t => t > 500);
            }


            Console.ReadLine();
        }


        //重複的code封裝起來,delegate封裝與解耦
        //寫一個方法去判斷邏輯並交給委派
        //public static List<T> getElements<T>(this List<T> list, Func<T, bool> func)
        //public static List<int> getElements(this List<int> list, Func<int, bool> func)
        public static List<int> getElements(List<int> list, Func<int, bool> func)
        {
            //List<T> data = new List<T>();
            //foreach (T t in list)
            List<int> data = new List<int>();
            foreach (int t in list)
            {
                // if (t > 500)
                //    data.Add(t);

                if (func.Invoke(t))
                    data.Add(t);
            }

            return data;
        }
    }
}
