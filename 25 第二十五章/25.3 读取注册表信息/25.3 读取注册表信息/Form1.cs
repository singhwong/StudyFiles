using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace _25._3_读取注册表信息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey software = hklm.OpenSubKey("Software");
            RegistryKey win = software.OpenSubKey("Microsoft");
            RegistryKey windows = win.OpenSubKey("Windows");
            listBox1.Items.Clear();

            foreach (string site in windows.GetSubKeyNames())
            {
                //if (site == "CurrentVersion")
                    if (site == "HTML Help")

                    {
                        RegistryKey sitekey = windows.OpenSubKey(site);
                    foreach (string sValName in sitekey.GetValueNames())
                    {
                        listBox1.Items.Add(""+sValName+":"+sitekey.GetValue(sValName));
                    }
                }
            }
            if(listBox1.Items.Count==0)
                MessageBox.Show("未找到相关数据");
            else
                MessageBox.Show("读取完成");

        }
    }
}
