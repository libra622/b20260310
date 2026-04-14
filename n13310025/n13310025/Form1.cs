using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n13310025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ClickMe_Click(object sender, EventArgs e)
        {
            if (btn_ClickMe.Text == "點我一下")
                btn_ClickMe.Text ="我已經被點擊過了";
            else if (btn_ClickMe.Text == "我已經被點擊過了")
                btn_ClickMe.Text ="點我一下";
        }

        private void btn_ChangeLabel_Click(object sender, EventArgs e)
        {
            lab_ChangeLabel.Text="按鈕被按過了";
        }

        private void btn_Counter_Click(object sender, EventArgs e)
        {
            String count = lab_Counter.Text;
            int sum = Int32.Parse(count)+1;
            lab_Counter.Text = sum.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Formbuttonbiger().Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            label2.Text=str;
        }
    }
}
