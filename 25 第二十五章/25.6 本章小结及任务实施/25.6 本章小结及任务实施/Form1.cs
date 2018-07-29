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

namespace _25._6_本章小结及任务实施
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            RegistryKey hkcu = Registry.CurrentUser;
            RegistryKey IEIcon = hkcu.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", true);
            IEIcon.SetValue("{B416D21B-3B22-B6D4-BBD3-BBD452DB3D5B}",0);
            MessageBox.Show("IE图标已经恢复至桌面，刷新桌面即可查看");
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            RegistryKey hkcu = Registry.CurrentUser;
            RegistryKey IEIcon = hkcu.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\HideDesktopIcons\NewStartPanel", true);
            IEIcon.SetValue("{B416D21B-3B22-B6D4-BBD3-BBD452DB3D5B}", 1);
            MessageBox.Show("IE图标已经从桌面删除，刷新桌面即可查看删除结果");
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            RegistryKey hkcu = Registry.CurrentUser;
            RegistryKey homePage1 = hkcu.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main",true);
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey homePage2 = hkcu.OpenSubKey(@"Software\Microsoft\Internet Explorer\Main", true);
            if (textBox1.Text != "")
            {

                homePage1.SetValue("StartPage",textBox1.Text);
                homePage2.SetValue("StartPage", textBox1.Text);
                MessageBox.Show("成功设定“"+textBox1.Text+"”为主页，重启后生效");

            }
            else
                MessageBox.Show("先输入网址再按按钮");
        }
    }
}
