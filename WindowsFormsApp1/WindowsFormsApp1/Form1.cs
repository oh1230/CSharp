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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StreamReader file = new StreamReader("data.csv");
            DataTable table = new DataTable();

            table.Columns.Add("コード");
            table.Columns.Add("タイトル");
            table.Columns.Add("価格");
            table.Columns.Add("数量");

            while (!file.EndOfStream)
            {
                string line = file.ReadLine();

                string[] data = line.Split(',');
                table.Rows.Add(data[0], data[1], data[2], data[3]);
            }
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string code = string.Empty;
            code = string.Format(textBox1.Text);
            string title = string.Empty;
            title = string.Format(textBox2.Text);
            string price = string.Empty;
            price = string.Format(textBox3.Text);
            string count = string.Empty;
            count = string.Format(textBox4.Text);

            SaveFileDialog save = new SaveFileDialog();
            
            save.Filter = "csv (*.csv)|*.csv|txt (*txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(save.FileName, false, Encoding.UTF8);

                string strtmp = "";
                strtmp += code + "," + title + "," + price + "," + count;

                sw.Write(strtmp + "\r\n");

                sw.Flush();
                sw.Close();
            }

            MessageBox.Show("保存完了");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
