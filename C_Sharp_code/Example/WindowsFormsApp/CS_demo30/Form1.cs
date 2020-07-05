using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //在DateSet上create StudentTable Object
        DataSet1.StudentDataTable stu = new DataSet1.StudentDataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            //create 連結器
            DataSet1TableAdapters.StudentTableAdapter da = new DataSet1TableAdapters.StudentTableAdapter();
            //將學生資料來源藉由DataAdapter放進DataSet建立的學生物件
            da.Fill(stu);
            //畫面呈現學生資料
            dataGridView1.DataSource = stu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.StudentTableAdapter da = new DataSet1TableAdapters.StudentTableAdapter();
            da.Update(stu);
            dataGridView1.DataSource = stu;
        }
      
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Don't throw an exception when we're done.
            e.ThrowException = false;            
            // Display an error message.
            string txt = "Error with " +
                dataGridView1.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message;
            MessageBox.Show(txt, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            // If this is true,then the user is trapped in this cell.
            e.Cancel = false;           
        }
    }
}
