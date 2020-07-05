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

namespace CS_demo24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\Public\Pictures\Sample Pictures\Chrysanthemum.jpg";

            //建立串流initialization
            FileStream fileStream = new FileStream(path, FileMode.Open);
            //建立讀取位元流
            BinaryReader reader = new BinaryReader(fileStream);
            //建立存放位元組的陣列
            int length = Convert.ToInt32(reader.BaseStream.Length);
            byte[] bytes = new byte[length];
            reader.Read(bytes, 0, length);
            reader.Close();
            fileStream.Close();


            //將陣列中的位元組寫出到textBox
            String newPath = "pict.jpg";
            //建立串流initialization
            //選擇 FileMode.Create
            FileStream fileStreamOut = new FileStream(newPath, FileMode.Create);
            //建立寫出位元流
            BinaryWriter writer = new BinaryWriter(fileStreamOut);
            writer.Write(bytes, 0, length);
            //圖片會複製到CS_demo24\bin\Debug底下中
            writer.Close();
            fileStreamOut.Close();
            pictureBox1.Image = Image.FromFile(newPath);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fw = new FileStream(@"fw.bin", FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fw);
            bool boolValue = true;
            bw.Write(boolValue);

            byte byteValue = 1;
            bw.Write(byteValue);

            int intValue = 7;
            bw.Write(intValue);

            byte[] byteArrayValue = { 65, 66, 67, 68 };
            bw.Write(byteArrayValue);

            char charValue = '中';
            bw.Write(charValue);
            bw.Close();
            fw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"fw.bin", FileMode.Open);
            BinaryReader br = new BinaryReader(fs);
            bool boolValue = br.ReadBoolean();
            Console.WriteLine(boolValue);

            byte byteValue = br.ReadByte();
            Console.WriteLine(byteValue);

            int intValue = br.ReadInt32();
            Console.WriteLine(intValue);

            byte[] byteArrayValue = br.ReadBytes(4);
            foreach (byte t in byteArrayValue)
                Console.Write(Convert.ToChar(t) + " ");
            Console.WriteLine();

            char charValue = br.ReadChar();
            Console.WriteLine(charValue);

            br.Close();
            fs.Close();
        }
    }
}
