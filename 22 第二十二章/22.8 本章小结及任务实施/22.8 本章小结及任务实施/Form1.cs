using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._8_本章小结及任务实施
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int width = 200;
        int height = 100;
        int x = 50;
        int y = 20;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = new Rectangle(x, y, width, height);
            Pen p = new Pen(Color.Gray);
            for (int i= y;i<3* y;i++)
            {
                Rectangle tempR = new Rectangle(x, i, width, height);
                g.DrawEllipse(p,tempR);
            }
            Brush b = new  SolidBrush(Color.Gainsboro);
            g.FillPie(b, r, 0, 360);
            b = new SolidBrush(Color.Blue);
            g.FillPie(b, r, 60, 150);
            b = new SolidBrush(Color.Yellow);
            g.FillPie(b, r, 210, 150);
            g.Dispose();
            b.Dispose();
        }
    }
}
