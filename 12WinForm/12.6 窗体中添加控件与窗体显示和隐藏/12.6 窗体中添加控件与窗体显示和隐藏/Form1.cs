using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._6_窗体中添加控件与窗体显示和隐藏
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button mybutton = new Button();
            mybutton.Text = "我要自学网";
            this.Controls.Add(mybutton);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Form2 myfrm2 = new Form2();
            myfrm2.Show();
        }
    }
}
