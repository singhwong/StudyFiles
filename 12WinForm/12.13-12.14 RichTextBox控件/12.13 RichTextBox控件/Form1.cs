using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._13_RichTextBox控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bluebtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Blue;

        }

        private void redbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Red;
        }

        private void ls18btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("隶书",18);
        }

        private void ls20btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("隶书",20);
        }

        private void kt18btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("楷体",18);
        }

        private void kt20btn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("楷体",20);
        }

        private void itembtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = true;
        }

        private void dwbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Gray;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font("宋体",15);
            richTextBox1.SelectionColor = Color.Black;
            richTextBox1.SelectionBullet = false;
            richTextBox1.SelectionBackColor = Color.White;
        }
    }
}
