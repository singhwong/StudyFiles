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

namespace _20._18_文件选择之OpenFileDialog控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = @"D:\Users\Walker\Desktop\51zxw";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文件(*.txt)|*.txt|Word文件(*.doc,*.docx)|*.doc;*.docx|所有文件(*.*)|*.*";
            //文件筛选器的设定
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.Title = "OpenFileDialog实例";
            openFileDialog1.FileName = "123";
            openFileDialog1.ShowHelp = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fName = openFileDialog1.FileName;
                string fileCon = "";
                StreamReader sr = new StreamReader(fName,System.Text.Encoding.GetEncoding("gb2312"));
                while ((fileCon = sr.ReadLine()) != null)
                {
                    textBox1.Text += fileCon;
                }
                sr.Close();
            }

        }
    }
}
