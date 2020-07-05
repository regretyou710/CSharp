using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //建立Calculator物件
            Calculator calculator = new Calculator();
            //建立委派物件並宣告指向哪一個函數(目標物件.目標方法名稱)

            Calc calc = new Calc(calculator.add); //等同於 Calc calc = calculator.add;           
            double i = 1000;
            double j = 200;
            double k = 0;

            //間接調用
            k = calc.Invoke(i, j);  //等同於 k = calc(i,j);          
            Console.WriteLine("間接調用 " + k);
            //直接調用
            Console.WriteLine("直接調用 " + calculator.add(i, j));


            //建立委派物件指向沒有回傳值的方法
            Calculator.Info info = new Calculator.Info(calculator.info);
            // 間接調用
            info.Invoke();//等同於 info();
            //直接調用
            calculator.info();


            Console.WriteLine("---------------");
            //並行多個方法(同步處理)
            Calc calc2 = new Calc(calculator.add);
            //使用 += 來加入一個新的委派方法
            calc2 += new Calc(calculator.sub);
            double t = calc2(10, 5);
            //執行委派方法可以發現同時進行加法跟減法的方法
            Console.WriteLine(t);
            //使用 -= 來移除一個委派方法
            calc2 -= new Calc(calculator.sub);
            t = calc2(7, 5);
            Console.WriteLine(t);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            海豚 dolphin = new 海豚();
            //delegate的初始化 1.以class形式instance 2.以field形式用屬性set

            //方法一
            //海豚.表演特技型別 trick = new 海豚.表演特技型別(dolphin.噴濕觀眾);


            //方法二,設定屬性         
            dolphin.特技 = new 海豚.表演特技型別(dolphin.噴濕觀眾);
            //dolphin.特技 = new 海豚.表演特技型別(dolphin.跳火圈);
            dolphin.表演特技();


        }
        //宣告委派方法
        delegate double MathOperation(double input);
        private void button3_Click(object sender, EventArgs e)
        {
            //宣告一種類別叫做AsyncCallback(非同步)只向參考方法
            //方法型別 變數名稱 = 初始化(宣告一個方法指派);
            //有種像是只宣告欄位並指派給值,沒有使用屬性set指派的欄位
            AsyncCallback callback = myCallBackMath;//等同AsyncCallback callback = new AsyncCallback(new Form1().myCallBackMath)


            MathOperation op = new MathOperation(SimpleMath.calculator);//static不用new
            //執行非同步的動作                                                           
            op.BeginInvoke(0.25, callback, "HelloTest");

            MessageBox.Show("Hello 結束..");//因為現在要執行的程式中主要執行緒會先執行出來,執行完畢後換執行BeginInvoke程式
        }
        void myCallBackMath(IAsyncResult ar)
        {
            //IAsyncResult代表非同步的作業狀態
            //AsyncState取得使用者定義物件
            //AsyncResult封裝委派上面非同步作業的結果
            //AsyncDelegate取得非同步呼叫已叫用的委派物件。回傳:非同步呼叫已叫用委派物件

            object hello = ar.AsyncState;//ar的AsyncState方法結束會回傳一個 hello物件變數//像是object HelloTest = null;object helloa = HelloTest;
            AsyncResult asyncResult = (AsyncResult)ar;//hello物件變數就是AsyncResult的物件變數
            MathOperation op = (MathOperation)asyncResult.AsyncDelegate;//AsyncDelegate回傳asyncResult物件變數
            double rs = op.EndInvoke(ar);//EndInvoke呼叫完畢後將傳入數值的結果回傳回來
            Console.WriteLine("回呼回傳值: {0}, 資料引數: {1}", rs, hello);


        }

    }


}
