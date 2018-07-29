using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._10_button控件
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("逗你玩","这你都相信");
            //要想关闭所有的窗体,我们只需要关闭主窗体
            //Form1 myfrm1 = new Form1();
            //此处我们又新建了一个Form1的实例,并非已经打开的那个实例
            //解决问题:获取到当前打开的实例
            //this.Close();
            //实现方法:静态存储,全局共享
            Try._myfrm1.Close();
        }
    }
}
