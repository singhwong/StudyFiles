using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._5_窗体的常用事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //事件的本质是一个方法
            //MessageBox.Show("窗体加载完成");

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("你点击了我");
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("你双击了我");

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           //MessageBox.Show("你关闭了我");

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            this.Text = "我要自学网";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("你移动了我");

        }
    }
}
