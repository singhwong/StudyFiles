using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._2_创建Graphics对象与创建Pen对象
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g1 = e.Graphics;
            //创建一个Image对象
            Bitmap imgTemp = new Bitmap(200,200);
            Graphics g2 = Graphics.FromImage(imgTemp);

            Graphics g3 = this.CreateGraphics();

            MessageBox.Show("恭喜您！我要自学网的Graphics对象创建成功！");

        }
    }
}
