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

namespace CS_demo29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Car> list = new List<Car>();
            Car car = new Car(1, "BMW");
            list.Add(car);
            car = new Car(2, "BENZ");
            list.Add(car);
            car = new Car(3, "INFINITI");
            list.Add(car);
            car = new Car(4, "HONDA");
            list.Insert(1, car);
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            Console.WriteLine("================");
            list.RemoveAt(1);
            Car c = list[1];
            c.Model = "YARIS";
            foreach (Car obj in list)
                Console.WriteLine(obj);
            Console.WriteLine("================");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<string, Car> dic = new Dictionary<string, Car>();
            Car car = new Car(1, "BMW");
            dic.Add("bmw", car);
            car = new Car(2, "BENZ");
            dic.Add("benz", car);
            car = new Car(3, "INFINITI");
            dic.Add("infiniti", car);
            car = new Car(4,"YRIS");
            dic.Add("yris",car);

            //列出所有元素
            foreach (KeyValuePair<string, Car> entry in dic)
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            Console.WriteLine("================");

            //透過key對應value
            foreach (string k in dic.Keys)
                Console.WriteLine("{0}", dic[k]);
            Console.WriteLine("================");

            //移除元素
            dic.Remove("infiniti");
            //修改元素
            Car c2 = dic["benz"];
            c2.Model = "HONDA";
            foreach (KeyValuePair<string, Car> entry in dic)
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            Console.WriteLine("================");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortedList<string, Car> sort = new SortedList<string, Car>();
            Car car = new Car(1, "BMW");
            sort.Add("bmw", car);
            car = new Car(2, "BENZ");
            sort.Add("benz", car);
            car = new Car(3, "INFINITI");
            sort.Add("infiniti", car);
            car = new Car(4, "YRIS");
            sort.Add("yris",car);

            //列出所有元素
            foreach (KeyValuePair<string, Car> entry in sort)
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            Console.WriteLine("================");

            //透過key對應value
            foreach (string k in sort.Keys)
                Console.WriteLine("{0}", sort[k]);
            Console.WriteLine("================");

            //移除元素
            sort.Remove("infiniti");
            //修改元素
            Car c2 = sort["benz"];
            c2.Model = "HONDA";
            foreach (KeyValuePair<string, Car> entry in sort)
                Console.WriteLine("Key:{0}\tValue:{1}", entry.Key, entry.Value);
            Console.WriteLine("================");
        }
    }
}
