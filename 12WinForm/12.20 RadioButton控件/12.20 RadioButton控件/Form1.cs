using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._20_RadioButton控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string name = usertb.Text;
            string pwd = pwdtb.Text;
            if (radioButton1.Checked || radioButton2.Checked)
            {
                if(name=="admin"&&pwd=="admin"&&radioButton1.Checked)
                    MessageBox.Show("登录成功,您的账户类型为管理员","登录提示");
                else if (name == "guest" && pwd == "guest" && radioButton2.Checked)
                    MessageBox.Show("登录成功,您的账户类型为来宾", "登录提示");
                else
                {
                    MessageBox.Show("用户名或者密码错误,请重新输入","错误提示");
                    usertb.Clear();
                    pwdtb.Clear();
                    usertb.Focus();
                }
            }
            else
            {
                MessageBox.Show("请选择账户类型","出错提示");
            }
        }
    }
}
