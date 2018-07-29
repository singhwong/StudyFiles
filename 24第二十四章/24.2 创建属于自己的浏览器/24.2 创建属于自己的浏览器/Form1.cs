﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;

namespace _24._2_创建属于自己的浏览器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //记事本需要的变量
        [DllImport("User32.DLL")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, int wParam, string Iparam);
        [DllImport("User32.Dll")]
        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszWindow);
        public const uint WM_SETTEXT = 0x00C;
            
            //记事本需要的变量
        
        private void Open_Click(object sender, EventArgs e)
        {
            openPage();
        }

        private void openPage()
        {
            if (textBox1.Text.Length > 0)
            {
                webBrowser1.Navigate(textBox1.Text.Trim());
            }
            else
                MessageBox.Show("请正确输入您要访问的网址！！包括http://");
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            if (webBrowser1.Document.ActiveElement != null)
            {
                webBrowser1.Navigate(webBrowser1.Document.ActiveElement.GetAttribute("href"));
                textBox1.Text = webBrowser1.Document.ActiveElement.GetAttribute("href");
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                toolStrip1.Items[0].Enabled = true;
            }
            else
                toolStrip1.Items[0].Enabled = false;

            if (webBrowser1.CanGoForward)
            {
                toolStrip1.Items[1].Enabled = true;
            }
            else
                toolStrip1.Items[1].Enabled = false;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Name == "tsbBack")
                    webBrowser1.GoBack();
                if (e.ClickedItem.Name == "tsbForward")
                    webBrowser1.GoForward();
                if (e.ClickedItem.Name == "tsbRefresh")
                    webBrowser1.Refresh();
                if (e.ClickedItem.Name == "tsbHome")
                    webBrowser1.GoHome();
                if (e.ClickedItem.Name == "tsbStop")
                    webBrowser1.Stop();
                if (e.ClickedItem.Name == "tsbExit")
                    if (MessageBox.Show("确认退出浏览吗？", "退出对话对框", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                if (e.ClickedItem.Name == "tsbViewSource")
                {
                    WebRequest wrq = WebRequest.Create(textBox1.Text);
                    WebResponse wrs = wrq.GetResponse();
                    StreamReader sr = new StreamReader(wrs.GetResponseStream(), Encoding.Default);
                    string code = "";
                    while (sr.ReadLine() != null)
                    {
                        code += sr.ReadLine();
                    }
                    System.Diagnostics.Process pro = new System.Diagnostics.Process();
                    pro.StartInfo.FileName = "notepad.exe";//获取要启动的记事本
                    //不使用操作系统外壳启动程序进程
                    pro.StartInfo.RedirectStandardInput = true;//读取
                    pro.StartInfo.RedirectStandardOutput = true;//将应用程序写入到流中；
                    pro.Start();//启动
                    if (pro != null)
                    {
                        //调用API，传递数据
                        while (pro.MainWindowHandle == IntPtr.Zero)
                        {
                            pro.Refresh();
                        }
                        IntPtr vHandle = FindWindowEx(pro.MainWindowHandle, IntPtr.Zero, "Edit", null);
                        //传递数据给记事本
                        SendMessage(vHandle, WM_SETTEXT, 0, code);
                    }
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == 13) openPage();
        }
    }
}
