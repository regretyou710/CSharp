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

namespace CS_demo23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //using System.IO
            //直接建立一個檔案並寫入資料,非透過stream方式
            string filePath = "text1.txt";
            string[] strs = { "Line1", "Line2", "Line3" };//讀取陣列元素逐行寫入file
            File.WriteAllLines(filePath, strs);

            filePath = "text2.txt";
            string strContent = "這是一個C#.NET測驗內容..";//將字串一次全部寫入file
            File.WriteAllText(filePath, strContent);

            MessageBox.Show("寫入完成");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = "text1.txt";
            string[] strs = File.ReadAllLines(filePath);//讀取檔案中逐行字串存到陣列
            foreach (string t in strs)
            {
                //textBox1.Text = t;
                textBox1.AppendText(t + "\r\n");
            }
            filePath = "text2.txt";
            string strContent = File.ReadAllText(filePath);//一次全部讀取檔案中所有內容
            textBox1.AppendText(strContent);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //1.建立目錄路徑 2.取得目錄底下資料夾名稱 3.取得目錄底下檔案名稱

            //@ 在 C# 被定義為『特殊字元 (special characters)』
            //逐字解譯字串常值
            string dirPath = @"D:\TestDirectoryView";
            Directory.CreateDirectory(dirPath);
            //可利用目錄建立資料夾


            dirPath = @"D:\TestDirectory";
            String[] dirs = Directory.GetDirectories(dirPath);
            foreach (String t in dirs)
                Console.WriteLine("目錄/資料夾名稱:" + t);
            Console.WriteLine("===============");

            String[] files = Directory.GetFiles(dirPath);
            foreach (String t in files)
                Console.WriteLine("目錄/檔案名稱:" + t);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String path = @"D:\TestDirectoryView";
            DirectoryInfo dirPath = new DirectoryInfo(path);           
            bool exists = dirPath.Exists;
            Console.WriteLine("目錄是否存在:" + exists);

           
            dirPath = new DirectoryInfo(@"D:\TestDirectory");
            DirectoryInfo[] dirs = dirPath.GetDirectories();
            foreach (DirectoryInfo t in dirs)
                Console.WriteLine("資料夾名稱:" + t.Name);//印出名稱
            Console.WriteLine("===============");

            FileInfo[] files = dirPath.GetFiles();
            foreach (FileInfo t in files)
                Console.WriteLine("目錄/資料夾名稱:" + t.FullName);//印出目錄加名稱

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String myFile = @"D:\TestDirectory\File1.txt";
            Console.WriteLine("取得Path目錄名稱:{0} ", Path.GetDirectoryName(myFile));
            Console.WriteLine("取得Path附檔名名稱:{0} ", Path.GetExtension(myFile));
            Console.WriteLine("取得Path檔案名稱(含附檔名):{0} ", Path.GetFileName(myFile));
            Console.WriteLine("取得Path檔案名稱(無附檔名):{0} ", Path.GetFileNameWithoutExtension(myFile));
            Console.WriteLine("隨機產生檔案名稱:{0} ", Path.GetRandomFileName());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            
            openDialog.Title = "打開舊檔";
            openDialog.Filter = "Word (*.doc)|*.doc; | Text (*.txt)|*.txt; | 所有檔案(*.*)|*.*;";//顯示的名稱|附檔名
            openDialog.ShowDialog();//顯示對話盒
            String selectFile = openDialog.FileName;
            Console.WriteLine(selectFile);//印出選擇的檔案名稱


            if (!selectFile.Equals(""))
            {
                Stream file = openDialog.OpenFile();

                byte[] bytes = new byte[file.Length];
                file.Read(bytes, 0, Convert.ToInt32(file.Length));
                file.Close();

                String str = "";
                foreach (byte t in bytes)
                {
                    //Console.Write(Convert.ToChar(t));
                    str += Convert.ToChar(t);
                }
                //Console.WriteLine();
                Form2 form2 = new Form2(str);
                form2.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "txt";//儲存檔案後預設附檔名
            saveDialog.Filter = " Text (*.txt)|*.txt; | Word (*.doc)|*.doc; | 所有檔案(*.*) | *.*; ";
            saveDialog.OverwritePrompt = true; //設定 檔案如果存在跳出顯示窗提示
            saveDialog.ShowDialog();
            String selectFile = saveDialog.FileName;
            Console.WriteLine(selectFile);//印出選擇的檔案名稱

            if (!selectFile.Equals(""))
            {
                FileInfo file = new FileInfo(selectFile);
                file.Create();                
                MessageBox.Show("存成完成");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }
    }
}
