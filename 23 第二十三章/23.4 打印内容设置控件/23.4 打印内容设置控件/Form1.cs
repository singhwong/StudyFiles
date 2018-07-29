using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23._4_打印内容设置控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                pageSetupDialog1.Document = printDocument1;
                pageSetupDialog1.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"页面设置出错",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"预览出错",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.Print();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "打印出错", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //左边距
            int x = e.PageBounds.Left;
            //上边距
            int y = e.PageBounds.Top;
            //获得绘图对象
            Graphics g = e.Graphics;
            Font printFont = new Font("Arial", 100);
            SolidBrush myBrush = new SolidBrush(Color.Black);
            g.DrawString("我要自学网创建的打印内容", printFont, myBrush, x, y);
        }
    }
}
