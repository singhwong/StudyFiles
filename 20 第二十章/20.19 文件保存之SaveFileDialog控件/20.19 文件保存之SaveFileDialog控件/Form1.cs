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

namespace _20._19_文件保存之SaveFileDialog控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory= @"D:\Users\Walker\Desktop\51zxw";
            saveFileDialog1.Filter = "文本文件(*.txt)|*.txt|97-2003Word文档(*.doc)|*.doc";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.FileName = "51zxw.net";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fName = saveFileDialog1.FileName;
                FileStream fs = File.Open(fName,FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(richTextBox1.Text);
                sw.Close();
                fs.Close();
            }


        }
    }
}
