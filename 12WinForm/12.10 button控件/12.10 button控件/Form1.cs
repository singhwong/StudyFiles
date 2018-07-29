using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._10_button控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Form2 myfrm2 = new Form2();
            //在内存中创建Form2的一个实例
            myfrm2.Show();
            //展示出来



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Try._myfrm1 = this;
        }
    }
}
