using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._3_ImageList控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img1 = Image.FromFile(@"D:\Users\Walker\Documents\Visual Studio 2015\Projects\51zxwProjects\13.3 ImageList控件\Imagelist\1.PNG");
            //声明了一个图像变量
            Image img2 = Image.FromFile(@"D:\Users\Walker\Documents\Visual Studio 2015\Projects\51zxwProjects\13.3 ImageList控件\Imagelist\2.PNG");
            Image img3 = Image.FromFile(@"D:\Users\Walker\Documents\Visual Studio 2015\Projects\51zxwProjects\13.3 ImageList控件\Imagelist\3.PNG");
            Image img4 = Image.FromFile(@"D:\Users\Walker\Documents\Visual Studio 2015\Projects\51zxwProjects\13.3 ImageList控件\Imagelist\4.PNG");
            Image img5 = Image.FromFile(@"D:\Users\Walker\Documents\Visual Studio 2015\Projects\51zxwProjects\13.3 ImageList控件\Imagelist\5.PNG");
            Image img6 = Image.FromFile(@"D:\Users\Walker\Documents\Visual Studio 2015\Projects\51zxwProjects\13.3 ImageList控件\Imagelist\6.PNG");


            //imageList控件添加元素的方法
            //1种 添加一个元素
            imageList1.Images.Add(img1);
            //2种 一次性添加多个元素
            imageList1.Images.AddRange(new Image[] { img2,img3,img4});
            //3 种  addStrip
            imageList1.Images.AddStrip(img5);
            imageList1.Images.AddStrip(img6);


            Graphics mygph = Graphics.FromHwnd(this.Handle);
            //创建了一个窗口句柄（handle） H  wnd window
            //了解一下graphics的一种声明方法
            
            for(int i=0;i<imageList1.Images.Count;i++)
            {

                imageList1.Draw(mygph, new Point(50, 50), i);
                //Draw有三种重载方式
                //1.（graphics对象名，左上角点坐标，索引值）
                //2.（graphics对象名，水平坐标，垂直坐标，索引值）
                //3.（graphics对象名，水平坐标，垂直坐标，图像宽度，图像高度，索引值）



                System.Threading.Thread.Sleep(1000);


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //删除imagelist对象的方法
            //removeAt(索引值)
            if (imageList1.Images.Count > 2)
            {
                imageList1.Images.RemoveAt(5);
                imageList1.Images.RemoveAt(4);
                imageList1.Images.RemoveAt(3);
                imageList1.Images.RemoveAt(2);


            }

            Graphics mygph = Graphics.FromHwnd(this.Handle);

            for (int i = 0; i < imageList1.Images.Count; i++)
            {

                imageList1.Draw(mygph, new Point(50, 50), i);
                //Draw有三种重载方式
                //1.（graphics对象名，左上角点坐标，索引值）
                //2.（graphics对象名，水平坐标，垂直坐标，索引值）
                //3.（graphics对象名，水平坐标，垂直坐标，图像宽度，图像高度，索引值）



                System.Threading.Thread.Sleep(1000);


            }
        }
    }
}
