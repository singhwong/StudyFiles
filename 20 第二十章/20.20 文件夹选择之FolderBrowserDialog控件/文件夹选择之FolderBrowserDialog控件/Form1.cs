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


namespace 文件夹选择之FolderBrowserDialog控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "请选择一个包含有TXT格式的文件夹：";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowNewFolderButton = false;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = folderBrowserDialog1.SelectedPath;
                string[] Files = Directory.GetFiles(fileName);
                foreach (string str in Files)
                {
                    if (str.Substring(str.LastIndexOf('.') + 1).ToLower() == "txt")
                    {
                        textBox1.AppendText(str+"\n");
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "请选择一个包含有DOC格式的文件夹：";
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.ShowNewFolderButton = true;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = folderBrowserDialog1.SelectedPath;
                string[] Files = Directory.GetFiles(fileName);
                foreach (string str in Files)
                {
                    if (str.Substring(str.LastIndexOf('.') + 1).ToLower() == "doc")
                    {
                        textBox1.AppendText(str + "\n");
                    }
                }
            }
        }
    }
}
