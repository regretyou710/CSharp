using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //先進先出(FIFO)
            QueueBuffer queueBuffer = new QueueBuffer();
            queueBuffer.sendMessage(new Messages("first"));
            queueBuffer.sendMessage(new Messages("second"));
            queueBuffer.receiveMessage();
            queueBuffer.sendMessage(new Messages("third"));
            queueBuffer.receiveMessage();
            queueBuffer.sendMessage(new Messages("fourth"));
            queueBuffer.receiveMessage();
            queueBuffer.receiveMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //後進先出(LIFO)
            StackBuffer stackBuffer = new StackBuffer();
            stackBuffer.sendMessage(new Messages("first"));
            stackBuffer.sendMessage(new Messages("second"));
            stackBuffer.sendMessage(new Messages("third"));
            stackBuffer.sendMessage(new Messages("fourth"));
            stackBuffer.receiveMessage();
            stackBuffer.receiveMessage();
            stackBuffer.receiveMessage();
            stackBuffer.receiveMessage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList list = new ArrayList();
            Car car = new Car(1,"BMW");
            list.Add(car);
            car = new Car(2, "BENZ");
            list.Add(car);
            car = new Car(3, "INFINITI");
            list.Add(car);
            car = new Car(4, "HONDA");
            list.Insert(1, car); //將HONDA插入到index 1
            for (int i=0; i<list.Count ;i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("----------------------");
            list.RemoveAt(1);//移除index 1資料
            Car car2 = (Car)list[2];
            car2.Model = "YARIS";
            foreach (Object obj in list)
            {
                Console.WriteLine(obj);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hashtable hashTable = new Hashtable();
            Car car = new Car(1, "BMW");
            hashTable.Add("bmw",car);
            car = new Car(2, "BENZ");
            hashTable.Add("benz",car);
            car = new Car(3, "INFINITI");
            hashTable.Add("infiniti",car);
            car = new Car(4, "HONDA");
            hashTable.Add("honda", car);

            //讀取hashTable內的資料
            foreach (DictionaryEntry entry in hashTable)
                Console.WriteLine("Key:{0}\tValue:{1}",entry.Key,entry.Value);
            Console.WriteLine("------------");

            //讀取key
            foreach (string s in hashTable.Keys)
                Console.WriteLine("{0}",hashTable[s]);
            Console.WriteLine("------------");

            //移除資料
            hashTable.Remove("honda");
            //修改資料
            Car c2 = (Car)hashTable["benz"];
            c2.Model = "YARIS";

            foreach (DictionaryEntry entry in hashTable)
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            Console.WriteLine("------------");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //照key的順序排序
            SortedList sortedList = new SortedList();
            Car car = new Car(1, "BMW");
            sortedList.Add("bmw", car);
            car = new Car(2, "BENZ");
            sortedList.Add("benz", car);
            car = new Car(3, "INFINITI");
            sortedList.Add("infiniti", car);
            car = new Car(4, "HONDA");
            sortedList.Add("honda", car);

            //讀取hashTable內的資料
            foreach (DictionaryEntry entry in sortedList)
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            Console.WriteLine("------------");

            //讀取key
            foreach (string s in sortedList.Keys)
                Console.WriteLine("{0}", sortedList[s]);
            Console.WriteLine("------------");

            //移除資料
            sortedList.Remove("honda");
            //修改資料
            Car c2 = (Car)sortedList["benz"];
            c2.Model = "YARIS";

            foreach (DictionaryEntry entry in sortedList)
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            Console.WriteLine("------------");
        }
    }
}
