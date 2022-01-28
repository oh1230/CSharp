using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Example
{
    public partial class Timer : Form
    {
        bool flag = false;
        int time = 600;
        int set_time = 600;

        public Timer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hour_TextBox.Text = (time / 3600).ToString();
            Min_TextBox.Text =((time % 3600) / 60).ToString();
            Sec_TextBox.Text = (time % 60).ToString();

            if (time == 0)
            {
                timer1.Stop();
                Start_Stop_Button.Text = "Start";
                flag = false;
                time = set_time;
            }
            time--;
        }

        private void Start_Stop_Button_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                timer1.Start();
                flag = true;
                Start_Stop_Button.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                flag = false;
                Start_Stop_Button.Text = "Start";
            }
        }

        private void Set_Button_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, k = 0;

            try
            {
                if (!int.TryParse(Hour_TextBox.Text, out i) ||
                    !int.TryParse(Min_TextBox.Text, out j) ||
                    !int.TryParse(Sec_TextBox.Text, out k))
                {
                    MessageBox.Show("数字だけを入力してください", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Convert.ToInt32(Hour_TextBox.Text) < 0 ||
                        Convert.ToInt32(Min_TextBox.Text) < 0 ||
                        Convert.ToInt32(Sec_TextBox.Text) < 0)
                    {
                        MessageBox.Show("０より大きい数字を入力してください。", "Warning！", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); 
                    }
                    else
                    {
                        set_time = Convert.ToInt32(Hour_TextBox.Text) * 3600 + Convert.ToInt32(Min_TextBox.Text) * 60 + Convert.ToInt32(Sec_TextBox.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n予想外エラー\nもう一度" + ex.ToString(), "Exception Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Hour_TextBox.Text = (set_time / 3600).ToString();
            Min_TextBox.Text = ((set_time % 3600) / 60).ToString();
            Sec_TextBox.Text = (set_time % 60).ToString();
            time = set_time;
        }
    }
}
