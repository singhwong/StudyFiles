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


namespace _20._21_文件监控之FileSystemWatcher控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileSystemWatcher1.EnableRaisingEvents = false;
            fileSystemWatcher1.Path= @"D:\Users\Walker\Desktop\51zxw";
            fileSystemWatcher1.Filter = "*.*";
            fileSystemWatcher1.IncludeSubdirectories = true;
            fileSystemWatcher1.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite;
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileSystemWatcher1.EnableRaisingEvents)
            {
                fileSystemWatcher1.EnableRaisingEvents = false;
                button1.Text = "启动";
            }
            else
            {
                fileSystemWatcher1.EnableRaisingEvents = true;
                button1.Text = "停止";
            }
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            textBox1.AppendText(DateTime.Now.ToString()+"更改目录文件"+Environment.NewLine);
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            textBox1.AppendText(DateTime.Now.ToString() + "创建了文件" + Environment.NewLine);
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            textBox1.AppendText(DateTime.Now.ToString() + "删除了文件" + Environment.NewLine);

        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            textBox1.AppendText(DateTime.Now.ToString() + "重命名了文件" + Environment.NewLine);

        }
    }
}
