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
    public partial class Form1 : Form
    {
        int count = 0;
        string csv;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            float wM = float.Parse(textBox5.Text) / 1000;
            float hM = float.Parse(textBox6.Text) / 1000;
            textBox7.Text = Convert.ToString(wM * hM);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "SS";
                textBox2.Text = "1";
                textBox3.Text = "1";
                textBox4.Text = "防火電動";

                StreamReader basedata = new StreamReader("base.csv");

                int num = 0;

                while (!basedata.EndOfStream)
                {
                    string line = basedata.ReadLine();

                    string[] data = line.Split(',');

                    treeView1.Nodes.Add(data[0]);
                    for (int i = 1; i < data.Length; i++)
                    {
                        treeView1.Nodes[num].Nodes.Add(data[i]);
                    }
                    num++;
                }
            }
            else
            {
                treeView1.Nodes.Clear();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox16.Clear();

            if (treeView1.SelectedNode.Parent == null)
            {
                treeView1.SelectedNode.Expand();
                textBox16.Text = treeView1.SelectedNode.Text + "/";
                hidden1.Text = treeView1.SelectedNode.Text;
            }
            else
            {
                textBox16.Text = treeView1.SelectedNode.Parent.Text + "/" + treeView1.SelectedNode.Text;
                hidden1.Text = treeView1.SelectedNode.Parent.Text;
                hidden2.Text = treeView1.SelectedNode.Text;
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text.Length > 0)
            {
                string[] textArray = textBox16.Text.Split('/');

                string text = textArray[1];

                if (text.Length > 0)
                {
                    StreamReader file = new StreamReader("data.csv");

                    while (!file.EndOfStream)
                    {
                        string line = file.ReadLine();

                        string[] data = line.Split(',');

                        if (data[0].Contains(text))
                        {
                            listBox1.Items.Clear();
                            for (int i = 1; i <= data.Length-1; i++)
                            {
                                listBox1.Items.Add("◎ :" + data[i]);
                            }
                        }
                    }
                }
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textbox8to17(hidden2.Text);

                csv += (hidden1.Text + "/" + hidden2.Text + "," + hidden3.Text + "\r\n");

                treeView2.Nodes.Add(hidden1.Text);
                treeView2.Nodes[count].Nodes.Add(hidden2.Text);
                treeView2.Nodes[count].Nodes[0].Nodes.Add(hidden3.Text);
                treeView2.ExpandAll();
                count++;
            }
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string[] ary = listBox1.SelectedItem.ToString().Split(':');
            hidden3.Text = ary[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidden1.Text = "";
            hidden2.Text = "";
            hidden3.Text = "";
            treeView1.Nodes.Clear();
            treeView2.Nodes.Clear();
            listBox1.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            count = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void hidden3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.Show();

            form2.setcsv(csv);
        }

        public void textbox8to17 (string hidden2)
        {
            if (hidden2 == "種類")
            {
                textBox8.Text = "製品名";
                textBox9.Text = hidden3.Text;
                textBox10.Text = "スラット種類";
                textBox11.Text = "A1:スチールt1";
                textBox14.Text = "開閉機仕様";
                textBox15.Text = "SG";
                textBox13.Text = "見えがかり材質";
                textBox17.Text = "スチール";
            }
            if (hidden2 == "開口寸法【Ｗ・Ｈ寸法】／W[mm]")
            {
                textBox5.Text = hidden3.Text;
            }
            if (hidden2 == "開口寸法【Ｗ・Ｈ寸法】／H[mm]")
            {
                textBox6.Text = hidden3.Text;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
