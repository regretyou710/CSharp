using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CS_demo22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] str = { 74, 65, 86, 65 };
            //插入IO類別
            //File是一種靜態class
            //檔案會產生在 CS_demo22\bin\Debug
            //在工具 -> 方案總管 -> 專案按顯示所有檔案可以看到
            FileStream fs = File.Create("text1.txt");
            fs.Write(str, 0, str.Length);
            fs.Close();
            MessageBox.Show("file saved");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy("text1.txt", "text1_new.txt");
            if (File.Exists("text1_new.txt"))
                MessageBox.Show("text1_new.txt Exists");
            else
                MessageBox.Show("text1_new.txt Not Exists");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists("text1_new.txt"))
                MessageBox.Show("text1_new.txt Exists");
            else
                MessageBox.Show("text1_new.txt Not Exists");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            File.Delete("text1_new.txt");
            if (File.Exists("text1_new.txt"))
                MessageBox.Show("text1_new.txt Exists");
            else
                MessageBox.Show("text1_new.txt Not Exists");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("text1.txt");
            FileStream fs = fileInfo.Open(FileMode.Open);//選擇開啟方法並產生串流物件
            byte[] bytes = new byte[fileInfo.Length];//建立byte陣列空間是text1.txt的長度大小來存放fs串流
            int size = -1;
            fs.Read(bytes, 0, Convert.ToInt32(fileInfo.Length));//將串流來源讀到陣列,從陣列中第0個開始讀到指定的位元組數
            foreach (byte t in bytes)
                Console.Write("{0}", Convert.ToChar(t));
            fs.Close();
            Console.WriteLine("");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("text2.txt");
            FileStream fs = fileInfo.Create();
            byte[] bytes = { 74, 65, 86, 65 };
            fs.Write(bytes,0,bytes.Length);
            fs.Close();
            fileInfo.CopyTo("text2_new.txt",true);//若允許覆寫現有檔案，則為 true，否則為 false
            MessageBox.Show("檔案Copy");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("text2_new.txt");
            fileInfo.Delete();
            if (fileInfo.Exists)
                MessageBox.Show("text2_new.txt Exists");
            else
                MessageBox.Show("text2_new.txt Not Exists");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo("text1.txt");
            //一個char占用一個byte
            Console.WriteLine("目前檔案(byte):" + fileInfo.Length); //取得目前檔案的大小，以位元組為單位。
        }
    }
}
