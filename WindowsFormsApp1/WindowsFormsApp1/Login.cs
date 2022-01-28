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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_input = textBox1.Text;
            string pass_input = textBox2.Text;

            if (id_input == "")
            {
                MessageBox.Show("IDを入力してください");
                return;
            }
            else if (pass_input == "")
            {
                MessageBox.Show("PASSWORDを入力してください");
                return;
            }
            else
            {
                StreamReader file = new StreamReader("login.csv");

                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();

                    string[] data = line.Split(',');
                    string id = data[0];
                    string pass = data[1];

                    if (id_input == id && pass_input == pass)
                    {
                        this.Visible = false;
                        Form1 showForm1 = new Form1();
                        showForm1.ShowDialog();
                    }
                }
                if (this.Visible)
                {
                    MessageBox.Show("IDやPASSWORDが違います。");
                    return;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
