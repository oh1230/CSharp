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

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        string csvFrm2;

        public void setcsv(string csv)
        {
            csvFrm2 = csv;
            textBox1.Text = csvFrm2;
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "csv (*.csv)|*.csv|txt (*txt)|*.txt|All files (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(save.FileName, false, Encoding.UTF8);

                sw.Write(csvFrm2);

                sw.Flush();
                sw.Close();
            }

            MessageBox.Show("保存完了");
        }
    }
}
