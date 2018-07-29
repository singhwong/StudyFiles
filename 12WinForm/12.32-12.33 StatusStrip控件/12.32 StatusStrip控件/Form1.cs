using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._32_StatusStrip控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            //获取当前行第一个字符所在的索引值
            int index = textBox1.GetFirstCharIndexOfCurrentLine();
            //计算行号
            int line = textBox1.GetFirstCharIndexFromLine(index) + 1;
            //计算列数
            int column = textBox1.SelectionStart - index + 1;
            //10 11 12 13 14 15 16
            toolStripStatusLabel3.Text = "第" + line + "行,第" + column + "列";
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            //获取当前行第一个字符所在的索引值
            int index = textBox1.GetFirstCharIndexOfCurrentLine();
            //计算行号
            int line = textBox1.GetFirstCharIndexFromLine(index) + 1;
            //计算列数
            int column = textBox1.SelectionStart - index + 1;
            //10 11 12 13 14 15 16
            toolStripStatusLabel3.Text = "第" + line + "行,第" + column + "列";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
