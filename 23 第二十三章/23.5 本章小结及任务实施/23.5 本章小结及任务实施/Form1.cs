using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23._5_本章小结及任务实施
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            printPreviewControl1.Visible = false;
            btnPrintCancel.Enabled = false;
        }

        private void btnPrintView_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewControl1.Document = printDocument1;
                printPreviewControl1.Visible = true;
                btnPrintView.Enabled = false;
                btnPrintCancel.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "预览出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintCancel_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Visible = false;
            btnPrintCancel.Enabled = false;
            btnPrintView.Enabled = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = e.PageBounds.Left+10;
            int y = e.PageBounds.Top+50;
            Graphics g = e.Graphics;
            Font printFont = new Font("黑体", 100);
            SolidBrush myBrush = new SolidBrush(Color.Green);
            g.DrawString("我要自学网", printFont, myBrush, x, y);
        }
    }
}
