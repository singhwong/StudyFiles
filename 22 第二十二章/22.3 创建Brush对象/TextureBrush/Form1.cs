using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextureBrush_walker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string path = @"D:\Users\Walker\Documents\Visual Studio 2015\Projects\51zxwProjects\22.3 创建Brush对象\TextureBrush\img\logo.jpg";
            Graphics g = e.Graphics;
            Bitmap img;
            if (File.Exists(path))
            {
                img = new Bitmap(path);
                Brush br = new TextureBrush(img);
                g.FillEllipse(br,0,80,650,280);
                br.Dispose();
            }
            else
                MessageBox.Show("要填充的图片不存在！");
            g.Dispose();
        }
    }
}
