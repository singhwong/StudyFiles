using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28_CRM_System
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private string user;
        public string User
        {
            get
            { return user; }
            set
            {
                user = value;
            }
        }
        private void main_Load(object sender, EventArgs e)
        {

        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确认退出系统", "退了m对话框", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Dispose();//窗体释放
                Application.Exit();//退出程序
            }
            else
            {
                e.Cancel = true;//取消事件
            }
        }

        private void lklblExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确认退出系统", "退了m对话框", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Dispose();//窗体释放
                Application.Exit();//退出程序
            }
           
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你确认退出系统", "退了m对话框", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Dispose();//窗体释放
                Application.Exit();//退出程序
            }
           
        }

        private void lklblAddclient_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Addclient ac = new Addclient();
            ac.Show();
        }

        private void lklblAddService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Addservice aser= new Addservice();
            aser.Show();
        }

        private void lklblComplaint_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddComplaint acom = new AddComplaint();
            acom.Show();
        }

        private void 添加客户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addclient ac = new Addclient();
            ac.Show();
        }

        private void 管理客户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client cli = new client();
            cli.Show();
        }

        private void 添加服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addservice aser = new Addservice();
            aser.Show();
        }

        private void 添加投诉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddComplaint acom = new AddComplaint();
            acom.Show();
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePwd cp = new changePwd();
            cp.Show();
        }

        private void 关于软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.Show();
        }
    }
}
