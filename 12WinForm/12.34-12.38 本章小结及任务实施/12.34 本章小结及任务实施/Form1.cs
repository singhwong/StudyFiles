using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._34_本章小结及任务实施
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "欢迎使用本系统,使用前请进行登录";
            toolStripStatusLabel2.Text = "我们的网站:   http://www.51zxw.net";
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
            menuStrip1.Visible = false;
            toolStrip1.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string pwd = textBox2.Text;
            if (name == "51zxw" && pwd == "51zxw")
            {
                MessageBox.Show("欢迎进入本系统", "登录成功");
                this.panel1.Visible = false;
                this.menuStrip1.Visible = true;
                toolStripStatusLabel1.Text = "登录成功!!数据无价,请注意随时保存!!";
                toolStripMenuItemShow.Enabled = true;
                toolStripMenuItemHide.Enabled = false;
            }
            else
            {

                MessageBox.Show("用户名或密码错误,请重新输入","登录失败");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            int maxval = 0;
            foreach (Form myform in this.MdiChildren)
            {
                int index =Convert.ToInt32( myform.Text.Substring(4, 1));
                if (index > maxval) maxval = index;
            }
            RegForm myRegForm = new RegForm();
            myRegForm.MdiParent = this;
            myRegForm.BringToFront();
            myRegForm.Text = "登记信息" +Convert.ToString(++maxval);
            myRegForm.Show();
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            activeForm.Close();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("退出请注意保存好所有文件\n请确认是否退出,退出请按是,取消请按否", "退出提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }

        private void toolStripMenuItemCas_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItemHor_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItemVer_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripMenuItemShow_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
            toolStripMenuItemHide.Enabled = true;
            toolStripMenuItemShow.Enabled = false;
        }

        private void toolStripMenuItemHide_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            toolStripMenuItemHide.Enabled = false;
            toolStripMenuItemShow.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int maxval = 0;
            foreach (Form myform in this.MdiChildren)
            {
                int index = Convert.ToInt32(myform.Text.Substring(4, 1));
                if (index > maxval) maxval = index;
            }
            RegForm myRegForm = new RegForm();
            myRegForm.MdiParent = this;
            myRegForm.BringToFront();
            myRegForm.Text = "登记信息" + Convert.ToString(++maxval);
            myRegForm.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form activeForm = this.ActiveMdiChild;
            activeForm.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("退出请注意保存好所有文件\n请确认是否退出,退出请按是,取消请按否", "退出提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本软件由我要自学网出品\n制作人:雪上行者","关于我们");
        }
    }
}
