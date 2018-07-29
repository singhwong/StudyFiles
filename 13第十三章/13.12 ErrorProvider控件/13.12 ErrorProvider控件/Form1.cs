using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._12_ErrorProvider控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ErrorProvider变量名.SetError(需要在哪个控件旁边显示错误信息（textBox1），显示错误信息的字符串（“您输入不正确”）);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 8 || textBox1.Text.Length > 10)
            {
                errorProvider1.SetError(textBox1, "用户名必须为8～12位");
                errorProvider1.Icon = new Icon(@"C:\Users\singhwong\Desktop\C#素材\C#素材\13第十三章\13.12 ErrorProvider控件\ico\error.ico");
            }
            else
            {
                errorProvider1.SetError(textBox1,"通过验证");
                errorProvider1.Icon = new Icon(@"C: \Users\singhwong\Desktop\C#素材\C#素材\13第十三章\13.12 ErrorProvider控件\ico\true.ico");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
            {
                errorProvider2.SetError(textBox3, "两次输入的密码不一致");
                errorProvider2.Icon = new Icon(@"C:\Users\singhwong\Desktop\C#素材\C#素材\13第十三章\13.12 ErrorProvider控件\ico\error.ico");

            }
            else
            {
                errorProvider2.SetError(textBox2,"通过验证");
                errorProvider2.SetError(textBox3, "通过验证");
                errorProvider2.Icon = new Icon(@"C:\Users\singhwong\Desktop\C#素材\C#素材\13第十三章\13.12 ErrorProvider控件\ico\true.ico");

            }
        }
    }
}
