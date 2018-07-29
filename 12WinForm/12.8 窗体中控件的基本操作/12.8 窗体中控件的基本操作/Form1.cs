using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._8_窗体中控件的基本操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button9.Size = new Size(200,200);//大小的调整
            button5.BringToFront();//置于顶层
            button7.SendToBack();//置于底层
            button7.Location = new System.Drawing.Point(60,50);
        }
    }
}
