using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._2_PictureBox控件_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 0;
        //获取指定文件夹下所有文件的全路径
       public string[] path = Directory.GetFiles(@"C:\Users\singhwong\Desktop\C#素材\C#素材\13第十三章\13.2 PictureBox控件（2）\logo图片集");

        private void Form1_Load(object sender, EventArgs e)
        {
            //设定图片如何在PictureBox中显示
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //设定PictureBox默认显示图片
            pictureBox1.Image = Image.FromFile(@"C: \Users\singhwong\Desktop\C#素材\C#素材\13第十三章\13.2 PictureBox控件（2）\logo图片集\4.png");
           
            }

        private void btnFore_Click(object sender, EventArgs e)
        {
            // 0 1 2 3 4 5 6
            //7
            i--;
            if (i < 0) i = path.Length-1;
            pictureBox1.Image = Image.FromFile(path[i]);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i > path.Length - 1) i = 0;
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
