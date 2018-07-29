using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._11_TextBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("按下2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("按下1");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label6.Text = textBox1.Text;
                    }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label7.Text = textBox2.Text;
        }
    }
}
