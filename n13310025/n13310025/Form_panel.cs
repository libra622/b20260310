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
    public partial class Form_panel : Form
    {
        public Form_panel()
        {
            InitializeComponent();
            if(!File.Exists("OrderData.csv"))
                FileDialog.WriteA11Text("OrderData.csv","時間,主食,配菜,飲品,甜點\n",Encoding.UTF8);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime durrentDateTime = DateTime.Now;
            string formatterDateTime = CurrentDateTime.ToString("yyyy/MM/dd HH:mm:ss");
            string food = "", sideFood = "", drink = "", dessert = "";
            
                foreach (Control c in panel1.Controls)//點
                {
                    if (c is CheckBox)
                    {
                        CheckBox temp = (CheckBox)c;
                        if (temp.Checked==true)
                        {
                            MessageBox.Show(temp.Text);
                        dessert+=" "+temp.Text;
                        }
                    }
                }
                foreach (Control c in panel2.Controls)//主
                {
                    if (c is CheckBox)
                    {
                        CheckBox temp = (CheckBox)c;
                        if (temp.Checked==true)
                        {
                            MessageBox.Show(temp.Text);
                        food+=" "+temp.Text;
                        }
                    }
                }
            foreach (Control c in panel3.Controls)//配
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked==true)
                    {
                        MessageBox.Show(temp.Text);
                        sideFood+=" "+temp.Text;
                    }
                }
            }
            foreach (Control c in panel4.Controls)//飲料
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked==true)
                    {
                        MessageBox.Show(temp.Text);
                        drink+=" "+temp.Text;
                    }
                }
            }



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

