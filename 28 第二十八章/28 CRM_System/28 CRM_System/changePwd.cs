using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient();

namespace _28_CRM_System
{
    public partial class changePwd : Form
    {
        public changePwd()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        common com = new common();
        database db = new database();
        private string user;
        public string User
        {
          
            get { return user; }
            set { user = value; }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (tbOldPwd.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入原密码");
                tbOldPwd.Focus();
                return;
            }
            if (tbNewPwd.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请输入新密码");
                tbNewPwd.Focus();
                return;
            }
            if (tbConfirmPwd.Text.Trim().Length <= 0)
            {
                MessageBox.Show("请再次输入新密码");
                tbConfirmPwd.Focus();
                return;
            }

            if (string.Compare(tbNewPwd.Text.Trim(), tbConfirmPwd.Text.Trim()) != 0)
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！");
                tbNewPwd.Focus();
                return;
            }
            int t;
            string sql = "select count(*) from manager where username='" + user + "'and pwd='" + com.md5(tbOldPwd.Text.Trim()) + "'";
            t = db.runSqlInt(sql);
            if (t > 0)
            {
                string updateSql = "update manager set pwd='" + com.md5(tbNewPwd.Text.Trim()) + "'where username='" + user + "'";
                db.runSql(updateSql);
                MessageBox.Show("密码修改成功");
            }
            else
            {
                MessageBox.Show("旧密码输入错误");
                tbOldPwd.Focus();
            }



        }
    }
}
