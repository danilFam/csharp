using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace starter_l8_task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                if (Convert.ToDouble(textBox2.Text)!=0)
                {
                    textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text));
                }
                else
                {
                    textBox3.Text = "На нуль делить нельзя";
                }
            }
            if (radioButton2.Checked==true)
            {
                textBox3.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text));
            }
            if (radioButton3.Checked==true)
            {
                textBox3.Text = textBox1.Text + textBox2.Text;
            }
            if (radioButton4.Checked==true)
            {
                textBox3.Text = Convert.ToString(Math.Pow(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
            }
        }
    }
}
