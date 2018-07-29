using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._23_NumericUpDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "将显示结果";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Increment = int.Parse(textBox2.Text);

            }
            catch
            {
                MessageBox.Show("设置的增量值有误");
                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.DecimalPlaces = int.Parse(textBox1.Text);
            }

            catch
            {
                MessageBox.Show("设置的小数位数值有误");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.UpButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1.DownButton();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = numericUpDown1.Value.ToString();
        }
    }
}
