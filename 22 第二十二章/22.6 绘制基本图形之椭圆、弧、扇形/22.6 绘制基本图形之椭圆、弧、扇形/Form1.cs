using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._6_绘制基本图形之椭圆_弧_扇形
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Cyan,3);
            g.DrawEllipse(p,0,50,300,120);
            g.DrawArc(p,0,50,200,200,0,120);
            //startangle 从X轴开始沿顺时针方向旋转的角度
            //sweepangle 从起始角开始到弧线的结束点沿顺时针方向角度的角（以度为单位）

            g.DrawPie(p,0,200,300,200,50,120);

            g.Dispose();
            p.Dispose();
        }
    }
}
