using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_demo26
{
    class 海豚
    {
        public delegate void 表演特技型別();

        //宣告型別叫做表演特技型別的欄位並產生屬性進行set
        private 表演特技型別 _特技;//一種方法型別的欄位
        public 表演特技型別 特技
        {
            set { _特技 = value; }
        }
        public void 表演特技()
        {//設定一個在執行delegate物件前判斷是否有intance
            if (_特技!=null)
            {
                //_特技.Invoke();
                _特技();
            }
        }        
        public void 噴濕觀眾()
        {
            Console.WriteLine("向觀眾噴水");
        }
        public void 跳火圈()
        {
            Console.WriteLine("跳躍火圈");
        }
    }
}
