using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stu = new Student();
            stu.setNo(101);
            stu.setName("Eason");
            stu.setMajor("Chinese");
            stu.info();
            Student stu2 = new Student();
            stu2.info();
            Student stu3 = new Student(102, "Rose", "Math");
            stu3.info();
        }
        public class Student
        {
            private static int _count;
            private int _no;
            private string _name;
            private string _major;
            public Student()
            {
                _no = -1;
                _name = "NA";
                _major = "NA";
            }
            public Student(int no, string name, string major)
            {
                this._no = no;
                this._name = name;
                this._major = major;
            }
            public int getCount()
            {
                return _count;
            }
            public void setCount()
            {
                _count++;
            }
            public int getNo()
            {
                return _no;
            }
            public void setNo(int no)
            {
                this._no = no;
            }
            public string getName()
            {
                return _name;
            }
            public void setName(string name)
            {
                this._name = name;
            }
            public string getMajor()
            {
                return _major;
            }
            public void setMajor(string major)
            {
                this._major = major;
            }
            public void info()
            {
                Console.WriteLine(_no + "," + _name + "," + _major);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student obj1 = new Student();
            obj1.setCount();
            Student obj2 = new Student();
            Console.WriteLine(obj1.getCount() + " " + obj2.getCount());
            obj2.setCount();
            Console.WriteLine(obj1.getCount() + " " + obj2.getCount());
        }
    }
}
