using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _28_CRM_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //判断是否输入用户名
            if (tbUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入用户名！");
                tbUser.Focus();
                return;
            }
            //判断是否已输入密码

            if (tbPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入密码！");
                tbPwd.Focus();
                return;
            }

            //创建common对象
            common com = new common();
            //创建database对象
            database db = new database();
            //统计所输入的用户名和密码在对应数据表中的个数的查询语句
            int t = 0;
            string sql = "seclect count(*) from manager wherer username='"+tbUser.Text.Trim()+"'and pwd='"+com.md5(tbPwd.Text.Trim())+"'";
            //将对应表中数据条数放在变量t中
            t = db.runSqlInt(sql);
            if (t > 0)
            {
                this.Hide();
                main fmain = new main();
                fmain.User = tbUser.Text.Trim();
                fmain.Show();
            }
            else
            {
                MessageBox.Show("用户名或者密码错误！！");
            }

        }
    }
}
