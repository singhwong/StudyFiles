using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polygonDraw
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
            Pen p = new Pen(Color.Green, 3);
            Point[] pg = {
                new Point(0,76),
                new Point(80,76),
                new Point(106,0),
                new Point(130,76),
                new Point(210,76),
                new Point(146,124),
                 new Point(170,200),
                new Point(106,152),
                new Point(40,200),
                new Point(66,124),              

            };
            g.DrawPolygon(p, pg);
            g.Dispose();
            p.Dispose();
        }
    }
}
