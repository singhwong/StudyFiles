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

namespace _25._4_新增注册表信息
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbKey.Text != "")
            {
                listBox1.Items.Clear();
                RegistryKey hklm = Registry.LocalMachine;
                RegistryKey sys = hklm.OpenSubKey("System", true);
                RegistryKey addText = sys.CreateSubKey(tbKey.Text);
                addText.SetValue(tbName.Text,tbValue.Text);
                foreach (string site in sys.GetSubKeyNames())
                {
                    if (site == tbKey.Text)
                    {
                        RegistryKey sitekey = sys.OpenSubKey(site);
                        foreach (string sValName in sitekey.GetSubKeyNames())
                        {
                            listBox1.Items.Add(site+" "+sValName+":"+sitekey.GetValue(sValName));
                        }
                    }
                }
                LoadData();

            }
            else
                MessageBox.Show("无可添加数据");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey sys = hklm.OpenSubKey("System");
            foreach (string site in sys.GetSubKeyNames())
            {
                listBox1.Items.Add(site);
            }
        }
    }
}
